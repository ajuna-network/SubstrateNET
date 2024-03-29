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
    
    
    public sealed class AuthorshipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public AuthorshipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Authorship", "Uncles"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Authorship", "Author"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Authorship", "DidSetUncles"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> UnclesParams
        ///  Uncles
        /// </summary>
        public static string UnclesParams()
        {
            return RequestGenerator.GetStorage("Authorship", "Uncles", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Uncles
        ///  Uncles
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10> Uncles(CancellationToken token)
        {
            string parameters = AuthorshipStorage.UnclesParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10>(parameters, token);
        }
        
        /// <summary>
        /// >> AuthorParams
        ///  Author of current block.
        /// </summary>
        public static string AuthorParams()
        {
            return RequestGenerator.GetStorage("Authorship", "Author", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> Author(CancellationToken token)
        {
            string parameters = AuthorshipStorage.AuthorParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> DidSetUnclesParams
        ///  Whether uncles were already set in this block.
        /// </summary>
        public static string DidSetUnclesParams()
        {
            return RequestGenerator.GetStorage("Authorship", "DidSetUncles", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DidSetUncles
        ///  Whether uncles were already set in this block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.Bool> DidSetUncles(CancellationToken token)
        {
            string parameters = AuthorshipStorage.DidSetUnclesParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
    }
    
    public sealed class AuthorshipCalls
    {
        
        /// <summary>
        /// >> set_uncles
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetUncles(Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_runtime.generic.header.Header> new_uncles)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(new_uncles.Encode());
            return new Method(4, "Authorship", 0, "set_uncles", byteArray.ToArray());
        }
    }
    
    public enum AuthorshipErrors
    {
        
        /// <summary>
        /// >> InvalidUncleParent
        /// The uncle parent not in the chain.
        /// </summary>
        InvalidUncleParent,
        
        /// <summary>
        /// >> UnclesAlreadySet
        /// Uncles already set in the block.
        /// </summary>
        UnclesAlreadySet,
        
        /// <summary>
        /// >> TooManyUncles
        /// Too many uncles.
        /// </summary>
        TooManyUncles,
        
        /// <summary>
        /// >> GenesisUncle
        /// The uncle is genesis.
        /// </summary>
        GenesisUncle,
        
        /// <summary>
        /// >> TooHighUncle
        /// The uncle is too high in chain.
        /// </summary>
        TooHighUncle,
        
        /// <summary>
        /// >> UncleAlreadyIncluded
        /// The uncle is already included.
        /// </summary>
        UncleAlreadyIncluded,
        
        /// <summary>
        /// >> OldUncle
        /// The uncle isn't recent enough to be included.
        /// </summary>
        OldUncle,
    }
}
