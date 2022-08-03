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

        private static async Task Main(string[] args)
        {

            // configure serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
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
            await manager.RunAsync(new Account[] { Alice }, 1000);
        }
    }
}