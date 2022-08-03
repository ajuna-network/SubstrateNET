using Ajuna.NetApi.Model.Rpc;
using Serilog;

namespace SubstrateNET.NetApi.Demo
{
    public class QueueInfo
    {
        private string _state;

        public DateTime Created { get; private set; }

        public DateTime LastUpdated { get; private set; }

        public bool IsSuccess => _state == "Finalized";

        public bool IsFail => _state == "Invalid" 
                           || _state == "Dropped";

        public bool IsRunning => !IsSuccess && !IsFail;

        public bool IsFinish =>  IsSuccess || IsFail;

        public double TimeElapsed => DateTime.Now.Subtract(LastUpdated).TotalSeconds;

        public QueueInfo()
        {
            Created = DateTime.Now;
            LastUpdated = Created;
            _state = "";
        }

        public void Update(string state)
        {
            LastUpdated = DateTime.Now;
            _state = state;
        }

    }
    
    public class ExtrinsicManager
    {
        private int _ttl;
        private Dictionary<string, QueueInfo> _data;

        public int Running => _data.Values.Where(p => p.IsRunning).Count();

        public ExtrinsicManager(int ttl)
        {
            _ttl = ttl;
            _data = new Dictionary<string, QueueInfo>();
        }

        public void Add(string subscription)
        {
            _data.Add(subscription, new QueueInfo());

            if (_data.Count > 100)
            {
                Clean();
            }
        }

        public QueueInfo? Get(string id)
        {
            if (!_data.TryGetValue(id, out QueueInfo? queueInfo))
            {
                Log.Warning("Retrieving unregeistred or removed subscriptionId {id}", id);
                return queueInfo;
            }

            return queueInfo;
        }

        public void Clean()
        {
            var toRemove = new List<string>();
            foreach (var kvp in _data)
            {
                if (kvp.Value.TimeElapsed > _ttl)
                {
                    toRemove.Add(kvp.Key);
                }
            }

            foreach(var key in toRemove)
            {
                _data.Remove(key);
            }

            Log.Information("Removing {count} etrinsics", toRemove);
        }

        /// <summary>
        /// Simple extrinsic tester
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <param name="extrinsicUpdate"></param>
        public void ActionExtrinsicUpdate(string subscriptionId, ExtrinsicStatus extrinsicUpdate)
        {
            if (!_data.TryGetValue(subscriptionId, out QueueInfo queueInfo))
            {
                Log.Warning("Unregeistred or removed subscriptionId {id} got update", subscriptionId, extrinsicUpdate.ExtrinsicState);
                return;
            }

            switch (extrinsicUpdate.ExtrinsicState)
            {
                case ExtrinsicState.None:
                    if (extrinsicUpdate.InBlock?.Value.Length > 0)
                    {
                        queueInfo.Update("InBlock");
                    }
                    else if (extrinsicUpdate.Finalized?.Value.Length > 0)
                    {
                        queueInfo.Update("Finalized");
                    }
                    else
                    {
                        queueInfo.Update("None");
                    };
                    break;

                case ExtrinsicState.Future:
                    queueInfo.Update("Future");
                    break;

                case ExtrinsicState.Ready:
                    queueInfo.Update("Ready");
                    break;

                case ExtrinsicState.Dropped:
                    queueInfo.Update("Dropped");
                    break;

                case ExtrinsicState.Invalid:
                    queueInfo.Update("Invalid");
                    break;
            }
        }
    }
}