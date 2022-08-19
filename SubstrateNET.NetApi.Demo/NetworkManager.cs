using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Serilog;
using SubstrateNET.NetApi.Generated;
using SubstrateNET.NetApi.Generated.Model.frame_system;
using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
using SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress;
using SubstrateNET.NetApi.Generated.Storage;
using System.Diagnostics;

namespace SubstrateNET.NetApi.Demo
{
    internal class NetworkManager
    {
        private const int MAX_RUNNIG = 500;

        private string _webSocketUrl;

        private SubstrateClientExt _client;

        private ExtrinsicManager _extrinsicManger;

        private Random _random = new Random();

        public NetworkManager(string webSocketUrl)
        {
            _webSocketUrl = webSocketUrl;

            _client = new SubstrateClientExt(new Uri(_webSocketUrl));

            _extrinsicManger = new ExtrinsicManager(60);

            _random = new Random();
        }

        public async Task RunAsync(Account[] accounts, int amount)
        {
            await _client.ConnectAsync(true, CancellationToken.None);
            Log.Information("Client is connected {state}", _client.IsConnected);

            var chain = await _client.GetMethodAsync<string>("system_chain");
            Log.Information("Connected to {chain}", chain);

            List<Task> allTasks = new List<Task>();
            var watch = new Stopwatch();
            watch.Start();

            var faulted = 0;

            for (int i = 0; i < amount; i++)
            {
                foreach (var account in accounts)
                {
                    allTasks.Add(CreateAccountAsync(account, _extrinsicManger));
                }


                if (allTasks.Count > 200)
                {
                    while (allTasks.Any(p => !p.IsCompleted))
                    {
                        Thread.Sleep(1000);
                    }
                    Log.Information("Concurrent extrinsics RUN: {value1} RDY/FUT: {value2}/{value3} FIN/BLK: {value4}/{value5} DRP/INV: {value6}/{value7}", 
                        _extrinsicManger.Running, _extrinsicManger.Ready, _extrinsicManger.Future, _extrinsicManger.Finalized, _extrinsicManger.InBlock, _extrinsicManger.Dropped, _extrinsicManger.Invalid);
                    
                    if (allTasks.Any(p => p.IsFaulted))
                    {
                        faulted += allTasks.Where(p => p.IsFaulted).Count();
                    }
                    allTasks.Clear();
                }
            }

            Log.Information("Faulted tasks {value}", faulted);

            while (allTasks.Any(p => !p.IsCompleted))
            {
                Thread.Sleep(1000);
                Log.Information("Concurrent extrinsics RUN: {value1} RDY/FUT: {value2}/{value3} FIN/BLK: {value4}/{value5} DRP/INV: {value6}/{value7}", 
                    _extrinsicManger.Running, _extrinsicManger.Ready, _extrinsicManger.Future, _extrinsicManger.Finalized, _extrinsicManger.InBlock, _extrinsicManger.Dropped, _extrinsicManger.Invalid);
            }

            watch.Stop();
            while (_extrinsicManger.Running > 0)
            {
                Thread.Sleep(1000);
                Log.Information("Concurrent extrinsics RUN: {value1} RDY/FUT: {value2}/{value3} FIN/BLK: {value4}/{value5} DRP/INV: {value6}/{value7}", 
                    _extrinsicManger.Running, _extrinsicManger.Ready, _extrinsicManger.Future, _extrinsicManger.Finalized, _extrinsicManger.InBlock, _extrinsicManger.Dropped, _extrinsicManger.Invalid);

            }

            Log.Information("Creation of {amount} accounts took {time} sec.", amount * accounts.Length, watch.Elapsed.TotalSeconds);

            await _client.CloseAsync(CancellationToken.None);

            Log.Information("Client is connected {state}", _client.IsConnected);
        }

        private async Task CreateAccountAsync(Account main, ExtrinsicManager extrinsicManger)
        {
            var accountNew = CreateNewAccount();
            var id = await TransferAsync(main, accountNew, 100000000000000);
            if (id != null)
            {
                extrinsicManger.Add(id);
            }

        }

        private async Task<AccountInfo?> GetBalanceAsync(Account alice)
        {
            var accountId32 = new AccountId32();
            accountId32.Create(alice.Bytes);

            return await _client.SystemStorage.Account(accountId32, CancellationToken.None);
        }

        private async Task<string> TransferAsync(Account from, Account to, long amount)
        {
            var accountId32New = new AccountId32();
            accountId32New.Create(to.Bytes);

            var multiAddress = new EnumMultiAddress();
            multiAddress.Create(MultiAddress.Id, accountId32New);

            var baseCampactU128 = new BaseCom<U128>();
            baseCampactU128.Create(amount);

            return await _client.Author.SubmitAndWatchExtrinsicAsync(
                _extrinsicManger.ActionExtrinsicUpdate,
                BalancesCalls.TransferKeepAlive(multiAddress, baseCampactU128),
                from, new ChargeAssetTxPayment(0, 0), 64, CancellationToken.None);

        }

        public Account CreateNewAccount()
        {
            var randomBytes = new byte[16];
            _random.NextBytes(randomBytes);
            var mnemonic = string.Join(' ', Mnemonic.MnemonicFromEntropy(randomBytes, Mnemonic.BIP39Wordlist.English));
            return Mnemonic.GetAccountFromMnemonic(mnemonic, "", KeyType.Sr25519);
        }
    }
}