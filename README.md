# SubstrateNET
Generated Substrate NET SDK

This is a NET playground repo for the published monthly substrate [tags](https://github.com/paritytech/substrate/tags). To build towards a specific node, please follow the documentation in the [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK) repo.

## How to use

1. Launch a local substrate node on a monthly tag. ex. monthly-2022-07
```bash
git clone -b monthly-2022-07 --single-branch https://github.com/paritytech/substrate.git
cargo build -p node-cli --release
./target/release/substrate --dev
```

2. Load SubstrateNET on the same monthly tag as the node. ex. monthly-2022-07
```bash
git clone -b monthly-2022-07 --single-branch https://github.com/ajuna-network/SubstrateNET.git
```

3. Launch SubstrateNET.sln
start hacking with the SDK
