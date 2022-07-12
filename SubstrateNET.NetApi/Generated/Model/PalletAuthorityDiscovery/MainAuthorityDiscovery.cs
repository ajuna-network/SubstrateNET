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
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletAuthorityDiscovery
{
    
    
    public sealed class AuthorityDiscoveryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public AuthorityDiscoveryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuthorityDiscovery", "Keys"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuthorityDiscovery", "NextKeys"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7)));
        }
        
        /// <summary>
        /// >> KeysParams
        ///  Keys of the current authority set.
        /// </summary>
        public static string KeysParams()
        {
            return RequestGenerator.GetStorage("AuthorityDiscovery", "Keys", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Keys
        ///  Keys of the current authority set.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7> Keys(CancellationToken token)
        {
            string parameters = AuthorityDiscoveryStorage.KeysParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7>(parameters, token);
        }
        
        /// <summary>
        /// >> NextKeysParams
        ///  Keys of the next authority set.
        /// </summary>
        public static string NextKeysParams()
        {
            return RequestGenerator.GetStorage("AuthorityDiscovery", "NextKeys", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextKeys
        ///  Keys of the next authority set.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7> NextKeys(CancellationToken token)
        {
            string parameters = AuthorityDiscoveryStorage.NextKeysParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT7>(parameters, token);
        }
    }
    
    public sealed class AuthorityDiscoveryCalls
    {
    }
}
