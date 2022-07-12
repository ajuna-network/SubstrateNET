# SubstrateNET
Generated Substrate NET SDK

This is a NET playground repo for the published monthly substrate [tags](https://github.com/paritytech/substrate/tags). To build towards a specific node, please follow the documentation in the [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK) repo.

## How to use

1) Launch a local substrate node on a monthly tag. ex. monthly-2022-07
```bash
git clone -b monthly-2022-07 --single-branch https://github.com/paritytech/substrate.git
cargo build -p node-cli --release
./target/release/substrate --dev
```

2) Load SubstrateNET on the same monthly tag as the node. ex. monthly-2022-07
```bash
git clone -b monthly-2022-07 --single-branch https://github.com/ajuna-network/SubstrateNET.git
```

3) Launch SubstrateNET.sln
start hacking with the SDK
```csharp
using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace Ajuna.NetApi.RunConsole
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var config = new LoggerConfiguration();

            Log.Logger = config
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

            // CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();

            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            try
            {
                Console.WriteLine("Press Ctrl+C to end.");
                await MainAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
            }
        }


        private static async Task MainAsync(CancellationToken token)
        {
            var substrateClient = new SubstrateClient(new Uri("ws://127.0.0.1:9944"));

            await substrateClient.ConnectAsync(true, CancellationToken.None);

            Log.Information("substrateClient.IsConnected: {IsConnected}", substrateClient.IsConnected);

            var blockData = await substrateClient.Chain.GetBlockAsync();

            Log.Information("blockData: {blockData}", blockData);
        }
    }
}
```
