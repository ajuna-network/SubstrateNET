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
    
    
    public sealed class RandomnessCollectiveFlipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public RandomnessCollectiveFlipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("RandomnessCollectiveFlip", "RandomMaterial"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25)));
        }
        
        /// <summary>
        /// >> RandomMaterialParams
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        public static string RandomMaterialParams()
        {
            return RequestGenerator.GetStorage("RandomnessCollectiveFlip", "RandomMaterial", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25> RandomMaterial(CancellationToken token)
        {
            string parameters = RandomnessCollectiveFlipStorage.RandomMaterialParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT25>(parameters, token);
        }
    }
    
    public sealed class RandomnessCollectiveFlipCalls
    {
    }
}
