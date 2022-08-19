using Ajuna.NetApi;
using Ajuna.NetApi.Model.Types;
using Schnorrkel.Keys;
using Serilog;
using Serilog.Filters;

namespace SubstrateNET.NetApi.Demo
{
    internal class Program
    {
        private const string WEBSOCKET_URL = "ws://127.0.0.1:9944";

        public static MiniSecret MiniSecretAlice => new(Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"), ExpandMode.Ed25519);
        public static Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToBytes(), MiniSecretAlice.GetPair().Public.Key);
        
        public static MiniSecret MiniSecretBob => new(Utils.HexToByteArray("0x398f0c28f98885e046333d4a41c19cee4c37368a9832c6502f6cfd182e2aef89"), ExpandMode.Ed25519);
        public static Account Bob => Account.Build(KeyType.Sr25519, MiniSecretBob.ExpandToSecret().ToBytes(), MiniSecretBob.GetPair().Public.Key);

        public static MiniSecret MiniSecretCharlie => new(Utils.HexToByteArray("0xbc1ede780f784bb6991a585e4f6e61522c14e1cae6ad0895fb57b9a205a8f938"), ExpandMode.Ed25519);
        public static Account Charlie => Account.Build(KeyType.Sr25519, MiniSecretCharlie.ExpandToSecret().ToBytes(), MiniSecretCharlie.GetPair().Public.Key);

        public static MiniSecret MiniSecretDave => new(Utils.HexToByteArray("0x868020ae0687dda7d57565093a69090211449845a7e11453612800b663307246"), ExpandMode.Ed25519);
        public static Account Dave => Account.Build(KeyType.Sr25519, MiniSecretDave.ExpandToSecret().ToBytes(), MiniSecretDave.GetPair().Public.Key);

        public static MiniSecret MiniSecretEve => new(Utils.HexToByteArray("0x786ad0e2df456fe43dd1f91ebca22e235bc162e0bb8d53c633e8c85b2af68b7a"), ExpandMode.Ed25519);
        public static Account Eve => Account.Build(KeyType.Sr25519, MiniSecretEve.ExpandToSecret().ToBytes(), MiniSecretEve.GetPair().Public.Key);

        public static MiniSecret MiniSecretFerdie => new(Utils.HexToByteArray("0x42438b7883391c05512a938e36c2df0131e088b3756d6aa7a755fbff19d2f842"), ExpandMode.Ed25519);
        public static Account Ferdie => Account.Build(KeyType.Sr25519, MiniSecretFerdie.ExpandToSecret().ToBytes(), MiniSecretFerdie.GetPair().Public.Key);


        private static async Task Main(string[] args)
        {

            // configure serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo
                .Console()
                .CreateLogger();


            // Add this to your C# console app's Main method to give yourself
            // a CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, e) =>
            {
                Log.Information("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            try
            {
                Log.Information("Press Ctrl+C to end.");
                await MainAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
            }

            // Finally, once just before the application exits...
            Log.CloseAndFlush();
        }

        private async static Task MainAsync(CancellationToken token)
        {
            var manager = new NetworkManager(WEBSOCKET_URL);
            await manager.RunAsync(new Account[] { Alice, Bob, Charlie, Dave, Eve, Ferdie }, 500);
        }
    }
}