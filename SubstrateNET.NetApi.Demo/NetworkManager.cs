using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Serilog;
using SubstrateNET.NetApi.Generated;
using SubstrateNET.NetApi.Generated.Model.FrameSystem;
using SubstrateNET.NetApi.Generated.Model.PalletBalances;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Diagnostics;

namespace SubstrateNET.NetApi.Demo
{
    internal class NetworkManager
    {
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
            Console.WriteLine($"substrateClient.IsConnected {_client.IsConnected}");

            var chain = await _client.GetMethodAsync<string>("system_chain");
            Console.WriteLine($"connected to {chain}");

            List<Task> allTasks = new List<Task>();
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < accounts.Length; i++)
            {
                allTasks.Add(CreateAccountAsync($"T{i}", amount, accounts[i], _extrinsicManger));
            }

            while (allTasks.Any(p => !p.IsCompleted))
            {
                Thread.Sleep(1000);
                Console.WriteLine($"concurrent {_extrinsicManger.Running}");
            }
           
            watch.Stop();
            while (_extrinsicManger.Running > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Concurrent extrinsic {_extrinsicManger.Running}");
            }

            Console.WriteLine($"creation of {amount* accounts.Length} accounts took {watch.Elapsed.TotalSeconds} sec.");

            await _client.CloseAsync(CancellationToken.None);
            Console.WriteLine($"substrateClient.IsConnected {_client.IsConnected}");
        }

        private async Task CreateAccountAsync(string name, int amount, Account main, ExtrinsicManager extrinsicManger)
        {
            for (int i = 0; i < amount; i++)
            {
                var accountNew = CreateNewAccount();
                var id = await TransferAsync(main, accountNew, 100000000000000);
                if (id != null)
                {
                    _extrinsicManger.Add(id);
                }
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