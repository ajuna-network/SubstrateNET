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
    
    
    public sealed class ImOnlineStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ImOnlineStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ImOnline", "HeartbeatAfter"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ImOnline", "Keys"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ImOnline", "ReceivedHeartbeats"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>), typeof(SubstrateNET.NetApi.Generated.Model.frame_support.traits.misc.WrapperOpaque)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ImOnline", "AuthoredBlocks"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> HeartbeatAfterParams
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        public static string HeartbeatAfterParams()
        {
            return RequestGenerator.GetStorage("ImOnline", "HeartbeatAfter", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HeartbeatAfter
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> HeartbeatAfter(CancellationToken token)
        {
            string parameters = ImOnlineStorage.HeartbeatAfterParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> KeysParams
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        public static string KeysParams()
        {
            return RequestGenerator.GetStorage("ImOnline", "Keys", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Keys
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5> Keys(CancellationToken token)
        {
            string parameters = ImOnlineStorage.KeysParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5>(parameters, token);
        }
        
        /// <summary>
        /// >> ReceivedHeartbeatsParams
        ///  For each session index, we keep a mapping of `SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        public static string ReceivedHeartbeatsParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("ImOnline", "ReceivedHeartbeats", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> ReceivedHeartbeats
        ///  For each session index, we keep a mapping of `SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.frame_support.traits.misc.WrapperOpaque> ReceivedHeartbeats(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = ImOnlineStorage.ReceivedHeartbeatsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.frame_support.traits.misc.WrapperOpaque>(parameters, token);
        }
        
        /// <summary>
        /// >> AuthoredBlocksParams
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        public static string AuthoredBlocksParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("ImOnline", "AuthoredBlocks", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> AuthoredBlocks
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> AuthoredBlocks(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> key, CancellationToken token)
        {
            string parameters = ImOnlineStorage.AuthoredBlocksParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class ImOnlineCalls
    {
        
        /// <summary>
        /// >> heartbeat
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Heartbeat(SubstrateNET.NetApi.Generated.Model.pallet_im_online.Heartbeat heartbeat, SubstrateNET.NetApi.Generated.Model.pallet_im_online.sr25519.app_sr25519.Signature signature)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(heartbeat.Encode());
            byteArray.AddRange(signature.Encode());
            return new Method(21, "ImOnline", 0, "heartbeat", byteArray.ToArray());
        }
    }
    
    public enum ImOnlineErrors
    {
        
        /// <summary>
        /// >> InvalidKey
        /// Non existent public key.
        /// </summary>
        InvalidKey,
        
        /// <summary>
        /// >> DuplicatedHeartbeat
        /// Duplicated heartbeat.
        /// </summary>
        DuplicatedHeartbeat,
    }
}
