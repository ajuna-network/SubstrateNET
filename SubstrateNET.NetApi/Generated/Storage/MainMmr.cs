//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Storage
{
    
    
    public sealed class MmrStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public MmrStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Mmr", "RootHash"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.primitive_types.H256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Mmr", "NumberOfLeaves"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Mmr", "Nodes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Ajuna.NetApi.Model.Types.Primitive.U64), typeof(SubstrateNET.NetApi.Generated.Model.primitive_types.H256)));
        }
        
        /// <summary>
        /// >> RootHashParams
        ///  Latest MMR Root hash.
        /// </summary>
        public static string RootHashParams()
        {
            return RequestGenerator.GetStorage("Mmr", "RootHash", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> RootHash
        ///  Latest MMR Root hash.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.primitive_types.H256> RootHash(CancellationToken token)
        {
            string parameters = MmrStorage.RootHashParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.primitive_types.H256>(parameters, token);
        }
        
        /// <summary>
        /// >> NumberOfLeavesParams
        ///  Current size of the MMR (number of leaves).
        /// </summary>
        public static string NumberOfLeavesParams()
        {
            return RequestGenerator.GetStorage("Mmr", "NumberOfLeaves", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NumberOfLeaves
        ///  Current size of the MMR (number of leaves).
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U64> NumberOfLeaves(CancellationToken token)
        {
            string parameters = MmrStorage.NumberOfLeavesParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        /// <summary>
        /// >> NodesParams
        ///  Hashes of the nodes in the MMR.
        /// 
        ///  Note this collection only contains MMR peaks, the inner nodes (and leaves)
        ///  are pruned and only stored in the Offchain DB.
        /// </summary>
        public static string NodesParams(Ajuna.NetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("Mmr", "Nodes", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Nodes
        ///  Hashes of the nodes in the MMR.
        /// 
        ///  Note this collection only contains MMR peaks, the inner nodes (and leaves)
        ///  are pruned and only stored in the Offchain DB.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.primitive_types.H256> Nodes(Ajuna.NetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = MmrStorage.NodesParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.primitive_types.H256>(parameters, token);
        }
    }
    
    public sealed class MmrCalls
    {
    }
}
