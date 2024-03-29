# SubstrateNET
Generated Substrate NET SDK

This is a NET playground repo for the published monthly substrate [tags](https://github.com/paritytech/substrate/tags). To build towards a specific node, please follow the documentation in the [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK) repo.

![image](https://user-images.githubusercontent.com/17710198/179053169-72f64582-24f8-43cd-bf34-86d6660c7c81.png)

## How to use

### Run local substrate node
Currently you should find for the most actual monthly build a pre-generated tag in this repo, so make sure you chose a supported monthly substrate tag (ex. monthly-2022-11)

```bash
git clone -b monthly-2022-11 --single-branch https://github.com/paritytech/substrate.git
cargo build -p node-cli --release
./target/release/substrate --dev
```

### Load SubstrateNET
Use the same tag for the SubstrateNET.

```bash
git clone -b monthly-2022-11 --single-branch https://github.com/ajuna-network/SubstrateNET.git
```

### Launch Solution
Load solution `SubstrateNET.sln`

### Launch Service
Execute `SubstrateNET.RestService`
- might ask you to accept certificates for ssl

### Access Endpoints & Swagger
- Rest API: http://localhost:61752/swagger/index.html 
- WebSocket: http://localhost:61752/ws 

## Simple Program

A simple `Program.cs` to start hacking!

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
