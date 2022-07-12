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
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletWhitelist
{
    
    
    public sealed class WhitelistStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public WhitelistStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Whitelist", "WhitelistedCall"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256), typeof(BaseTuple)));
        }
        
        /// <summary>
        /// >> WhitelistedCallParams
        /// </summary>
        public static string WhitelistedCallParams(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Whitelist", "WhitelistedCall", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> WhitelistedCall
        /// </summary>
        public async Task<BaseTuple> WhitelistedCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = WhitelistStorage.WhitelistedCallParams(key);
            return await _client.GetStorageAsync<BaseTuple>(parameters, token);
        }
    }
    
    public sealed class WhitelistCalls
    {
        
        /// <summary>
        /// >> whitelist_call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method WhitelistCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 call_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call_hash.Encode());
            return new Method(48, "Whitelist", 0, "whitelist_call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_whitelisted_call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveWhitelistedCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 call_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call_hash.Encode());
            return new Method(48, "Whitelist", 1, "remove_whitelisted_call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch_whitelisted_call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DispatchWhitelistedCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 call_hash, Ajuna.NetApi.Model.Types.Primitive.U64 call_weight_witness)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call_hash.Encode());
            byteArray.AddRange(call_weight_witness.Encode());
            return new Method(48, "Whitelist", 2, "dispatch_whitelisted_call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch_whitelisted_call_with_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DispatchWhitelistedCallWithPreimage(SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumNodeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(48, "Whitelist", 3, "dispatch_whitelisted_call_with_preimage", byteArray.ToArray());
        }
    }
    
    public enum WhitelistErrors
    {
        
        /// <summary>
        /// >> UnavailablePreImage
        /// The preimage of the call hash could not be loaded.
        /// </summary>
        UnavailablePreImage,
        
        /// <summary>
        /// >> UndecodableCall
        /// The call could not be decoded.
        /// </summary>
        UndecodableCall,
        
        /// <summary>
        /// >> InvalidCallWeightWitness
        /// The weight of the decoded call was higher than the witness.
        /// </summary>
        InvalidCallWeightWitness,
        
        /// <summary>
        /// >> CallIsNotWhitelisted
        /// The call was not whitelisted.
        /// </summary>
        CallIsNotWhitelisted,
        
        /// <summary>
        /// >> CallAlreadyWhitelisted
        /// The call was already whitelisted; No-Op.
        /// </summary>
        CallAlreadyWhitelisted,
    }
}
