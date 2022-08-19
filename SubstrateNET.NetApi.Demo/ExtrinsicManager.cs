using Ajuna.NetApi.Model.Rpc;
using Serilog;

namespace SubstrateNET.NetApi.Demo
{
    public class QueueInfo
    {
        private string _state;

        public DateTime Created { get; private set; }

        public DateTime LastUpdated { get; private set; }

        public bool IsFail => _state == null
                           || _state == "Invalid"
                           || _state == "Dropped";

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

        public int Running => _data.Values.Count();

        public int Finalized { get; private set; } = 0;
        public int InBlock { get; private set; } = 0;
        public int Future { get; private set; } = 0;
        public int Ready { get; private set; } = 0;
        public int Dropped { get; private set; } = 0;
        public int Invalid { get; private set; } = 0;

        public ExtrinsicManager(int ttl)
        {
            _ttl = ttl;
            _data = new Dictionary<string, QueueInfo>();
        }

        public void Add(string subscription)
        {
            _data.Add(subscription, new QueueInfo());
        }

        public QueueInfo? Get(string id)
        {
            if (!_data.TryGetValue(id, out QueueInfo? queueInfo))
            {
                Log.Debug("Trying to acess queue info for unregistered or removed subscriptionId {id}", id);
                return queueInfo;
            }

            return queueInfo;
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
                Log.Debug("Unregistered or removed subscriptionId {id} got update", subscriptionId, extrinsicUpdate.ExtrinsicState);
                return;
            }

            switch (extrinsicUpdate.ExtrinsicState)
            {
                case ExtrinsicState.None:
                    if (extrinsicUpdate.InBlock?.Value.Length > 0)
                    {
                        InBlock += 1;
                        queueInfo.Update("InBlock");
                    }
                    else if (extrinsicUpdate.Finalized?.Value.Length > 0)
                    {
                        Finalized += 1;
                        _data.Remove(subscriptionId);
                    }
                    else
                    {
                        queueInfo.Update("None");
                    };
                    break;

                case ExtrinsicState.Future:
                    Future += 1;
                    queueInfo.Update("Future");
                    break;

                case ExtrinsicState.Ready:
                    Ready += 1;
                    queueInfo.Update("Ready");
                    break;

                case ExtrinsicState.Dropped:
                    Dropped += 1;
                    _data.Remove(subscriptionId);
                    break;

                case ExtrinsicState.Invalid:
                    Invalid += 1;
                    _data.Remove(subscriptionId);
                    break;
            }
        }
    }
}