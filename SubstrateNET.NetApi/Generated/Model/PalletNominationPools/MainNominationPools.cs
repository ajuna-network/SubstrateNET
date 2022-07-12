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
using SubstrateNET.NetApi.Generated.Model.FrameSupport;
using SubstrateNET.NetApi.Generated.Model.PalletNominationPools;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletNominationPools
{
    
    
    public sealed class NominationPoolsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public NominationPoolsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "MinJoinBond"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "MinCreateBond"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "MaxPools"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "MaxPoolMembers"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "MaxPoolMembersPerPool"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "PoolMembers"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), typeof(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.PoolMember)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForPoolMembers"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "BondedPools"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.BondedPoolInner)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForBondedPools"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "RewardPools"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.RewardPool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForRewardPools"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "SubPoolsStorage"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.SubPools)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForSubPoolsStorage"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "Metadata"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT31)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForMetadata"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "LastPoolId"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "ReversePoolIdLookup"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NominationPools", "CounterForReversePoolIdLookup"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> MinJoinBondParams
        ///  Minimum amount to bond to join a pool.
        /// </summary>
        public static string MinJoinBondParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "MinJoinBond", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MinJoinBond
        ///  Minimum amount to bond to join a pool.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> MinJoinBond(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MinJoinBondParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> MinCreateBondParams
        ///  Minimum bond required to create a pool.
        /// 
        ///  This is the amount that the depositor must put as their initial stake in the pool, as an
        ///  indication of "skin in the game".
        /// </summary>
        public static string MinCreateBondParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "MinCreateBond", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MinCreateBond
        ///  Minimum bond required to create a pool.
        /// 
        ///  This is the amount that the depositor must put as their initial stake in the pool, as an
        ///  indication of "skin in the game".
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> MinCreateBond(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MinCreateBondParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxPoolsParams
        ///  Maximum number of nomination pools that can exist. If `None`, then an unbounded number of
        ///  pools can exist.
        /// </summary>
        public static string MaxPoolsParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "MaxPools", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxPools
        ///  Maximum number of nomination pools that can exist. If `None`, then an unbounded number of
        ///  pools can exist.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> MaxPools(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MaxPoolsParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxPoolMembersParams
        ///  Maximum number of members that can exist in the system. If `None`, then the count
        ///  members are not bound on a system wide basis.
        /// </summary>
        public static string MaxPoolMembersParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "MaxPoolMembers", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxPoolMembers
        ///  Maximum number of members that can exist in the system. If `None`, then the count
        ///  members are not bound on a system wide basis.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> MaxPoolMembers(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MaxPoolMembersParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxPoolMembersPerPoolParams
        ///  Maximum number of members that may belong to pool. If `None`, then the count of
        ///  members is not bound on a per pool basis.
        /// </summary>
        public static string MaxPoolMembersPerPoolParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "MaxPoolMembersPerPool", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxPoolMembersPerPool
        ///  Maximum number of members that may belong to pool. If `None`, then the count of
        ///  members is not bound on a per pool basis.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> MaxPoolMembersPerPool(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MaxPoolMembersPerPoolParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> PoolMembersParams
        ///  Active members.
        /// </summary>
        public static string PoolMembersParams(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "PoolMembers", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PoolMembers
        ///  Active members.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.PoolMember> PoolMembers(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.PoolMembersParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.PoolMember>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForPoolMembersParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForPoolMembersParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForPoolMembers", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForPoolMembers
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForPoolMembers(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForPoolMembersParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> BondedPoolsParams
        ///  Storage for bonded pools.
        /// </summary>
        public static string BondedPoolsParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "BondedPools", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BondedPools
        ///  Storage for bonded pools.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.BondedPoolInner> BondedPools(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.BondedPoolsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.BondedPoolInner>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForBondedPoolsParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForBondedPoolsParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForBondedPools", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForBondedPools
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForBondedPools(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForBondedPoolsParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> RewardPoolsParams
        ///  Reward pools. This is where there rewards for each pool accumulate. When a members payout
        ///  is claimed, the balance comes out fo the reward pool. Keyed by the bonded pools account.
        /// </summary>
        public static string RewardPoolsParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "RewardPools", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> RewardPools
        ///  Reward pools. This is where there rewards for each pool accumulate. When a members payout
        ///  is claimed, the balance comes out fo the reward pool. Keyed by the bonded pools account.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.RewardPool> RewardPools(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.RewardPoolsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.RewardPool>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForRewardPoolsParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForRewardPoolsParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForRewardPools", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForRewardPools
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForRewardPools(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForRewardPoolsParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> SubPoolsStorageParams
        ///  Groups of unbonding pools. Each group of unbonding pools belongs to a bonded pool,
        ///  hence the name sub-pools. Keyed by the bonded pools account.
        /// </summary>
        public static string SubPoolsStorageParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "SubPoolsStorage", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SubPoolsStorage
        ///  Groups of unbonding pools. Each group of unbonding pools belongs to a bonded pool,
        ///  hence the name sub-pools. Keyed by the bonded pools account.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.SubPools> SubPoolsStorage(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.SubPoolsStorageParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletNominationPools.SubPools>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForSubPoolsStorageParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForSubPoolsStorageParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForSubPoolsStorage", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForSubPoolsStorage
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForSubPoolsStorage(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForSubPoolsStorageParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> MetadataParams
        ///  Metadata for the pool.
        /// </summary>
        public static string MetadataParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "Metadata", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Metadata
        ///  Metadata for the pool.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT31> Metadata(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.MetadataParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT31>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForMetadataParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForMetadataParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForMetadata", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForMetadata
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForMetadata(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForMetadataParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> LastPoolIdParams
        ///  Ever increasing number of all pools created so far.
        /// </summary>
        public static string LastPoolIdParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "LastPoolId", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> LastPoolId
        ///  Ever increasing number of all pools created so far.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> LastPoolId(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.LastPoolIdParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ReversePoolIdLookupParams
        ///  A reverse lookup from the pool's account id to its id.
        /// 
        ///  This is only used for slashing. In all other instances, the pool id is used, and the
        ///  accounts are deterministically derived from it.
        /// </summary>
        public static string ReversePoolIdLookupParams(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("NominationPools", "ReversePoolIdLookup", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReversePoolIdLookup
        ///  A reverse lookup from the pool's account id to its id.
        /// 
        ///  This is only used for slashing. In all other instances, the pool id is used, and the
        ///  accounts are deterministically derived from it.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> ReversePoolIdLookup(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = NominationPoolsStorage.ReversePoolIdLookupParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForReversePoolIdLookupParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForReversePoolIdLookupParams()
        {
            return RequestGenerator.GetStorage("NominationPools", "CounterForReversePoolIdLookup", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForReversePoolIdLookup
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForReversePoolIdLookup(CancellationToken token)
        {
            string parameters = NominationPoolsStorage.CounterForReversePoolIdLookupParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class NominationPoolsCalls
    {
        
        /// <summary>
        /// >> join
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Join(BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> amount, Ajuna.NetApi.Model.Types.Primitive.U32 pool_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(pool_id.Encode());
            return new Method(49, "NominationPools", 0, "join", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> bond_extra
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method BondExtra(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumBondExtra extra)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(extra.Encode());
            return new Method(49, "NominationPools", 1, "bond_extra", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_payout
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClaimPayout()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(49, "NominationPools", 2, "claim_payout", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unbond
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unbond(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 member_account, BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> unbonding_points)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(member_account.Encode());
            byteArray.AddRange(unbonding_points.Encode());
            return new Method(49, "NominationPools", 3, "unbond", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> pool_withdraw_unbonded
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PoolWithdrawUnbonded(Ajuna.NetApi.Model.Types.Primitive.U32 pool_id, Ajuna.NetApi.Model.Types.Primitive.U32 num_slashing_spans)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pool_id.Encode());
            byteArray.AddRange(num_slashing_spans.Encode());
            return new Method(49, "NominationPools", 4, "pool_withdraw_unbonded", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> withdraw_unbonded
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method WithdrawUnbonded(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 member_account, Ajuna.NetApi.Model.Types.Primitive.U32 num_slashing_spans)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(member_account.Encode());
            byteArray.AddRange(num_slashing_spans.Encode());
            return new Method(49, "NominationPools", 5, "withdraw_unbonded", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> create
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Create(BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> amount, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 root, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 nominator, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 state_toggler)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(root.Encode());
            byteArray.AddRange(nominator.Encode());
            byteArray.AddRange(state_toggler.Encode());
            return new Method(49, "NominationPools", 6, "create", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> nominate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Nominate(Ajuna.NetApi.Model.Types.Primitive.U32 pool_id, BaseVec<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> validators)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pool_id.Encode());
            byteArray.AddRange(validators.Encode());
            return new Method(49, "NominationPools", 7, "nominate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_state
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetState(Ajuna.NetApi.Model.Types.Primitive.U32 pool_id, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumPoolState state)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pool_id.Encode());
            byteArray.AddRange(state.Encode());
            return new Method(49, "NominationPools", 8, "set_state", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetMetadata(Ajuna.NetApi.Model.Types.Primitive.U32 pool_id, BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> metadata)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pool_id.Encode());
            byteArray.AddRange(metadata.Encode());
            return new Method(49, "NominationPools", 9, "set_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_configs
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetConfigs(SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp min_join_bond, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp min_create_bond, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp max_pools, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp max_members, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp max_members_per_pool)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(min_join_bond.Encode());
            byteArray.AddRange(min_create_bond.Encode());
            byteArray.AddRange(max_pools.Encode());
            byteArray.AddRange(max_members.Encode());
            byteArray.AddRange(max_members_per_pool.Encode());
            return new Method(49, "NominationPools", 10, "set_configs", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_roles
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UpdateRoles(Ajuna.NetApi.Model.Types.Primitive.U32 pool_id, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp new_root, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp new_nominator, SubstrateNET.NetApi.Generated.Model.PalletNominationPools.EnumConfigOp new_state_toggler)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pool_id.Encode());
            byteArray.AddRange(new_root.Encode());
            byteArray.AddRange(new_nominator.Encode());
            byteArray.AddRange(new_state_toggler.Encode());
            return new Method(49, "NominationPools", 11, "update_roles", byteArray.ToArray());
        }
    }
    
    public enum NominationPoolsErrors
    {
        
        /// <summary>
        /// >> PoolNotFound
        /// A (bonded) pool id does not exist.
        /// </summary>
        PoolNotFound,
        
        /// <summary>
        /// >> PoolMemberNotFound
        /// An account is not a member.
        /// </summary>
        PoolMemberNotFound,
        
        /// <summary>
        /// >> RewardPoolNotFound
        /// A reward pool does not exist. In all cases this is a system logic error.
        /// </summary>
        RewardPoolNotFound,
        
        /// <summary>
        /// >> SubPoolsNotFound
        /// A sub pool does not exist.
        /// </summary>
        SubPoolsNotFound,
        
        /// <summary>
        /// >> AccountBelongsToOtherPool
        /// An account is already delegating in another pool. An account may only belong to one
        /// pool at a time.
        /// </summary>
        AccountBelongsToOtherPool,
        
        /// <summary>
        /// >> InsufficientBond
        /// The pool has insufficient balance to bond as a nominator.
        /// </summary>
        InsufficientBond,
        
        /// <summary>
        /// >> AlreadyUnbonding
        /// The member is already unbonding in this era.
        /// </summary>
        AlreadyUnbonding,
        
        /// <summary>
        /// >> FullyUnbonding
        /// The member is fully unbonded (and thus cannot access the bonded and reward pool
        /// anymore to, for example, collect rewards).
        /// </summary>
        FullyUnbonding,
        
        /// <summary>
        /// >> MaxUnbondingLimit
        /// The member cannot unbond further chunks due to reaching the limit.
        /// </summary>
        MaxUnbondingLimit,
        
        /// <summary>
        /// >> CannotWithdrawAny
        /// None of the funds can be withdrawn yet because the bonding duration has not passed.
        /// </summary>
        CannotWithdrawAny,
        
        /// <summary>
        /// >> MinimumBondNotMet
        /// The amount does not meet the minimum bond to either join or create a pool.
        /// </summary>
        MinimumBondNotMet,
        
        /// <summary>
        /// >> OverflowRisk
        /// The transaction could not be executed due to overflow risk for the pool.
        /// </summary>
        OverflowRisk,
        
        /// <summary>
        /// >> NotDestroying
        /// A pool must be in [`PoolState::Destroying`] in order for the depositor to unbond or for
        /// other members to be permissionlessly unbonded.
        /// </summary>
        NotDestroying,
        
        /// <summary>
        /// >> NotOnlyPoolMember
        /// The depositor must be the only member in the bonded pool in order to unbond. And the
        /// depositor must be the only member in the sub pools in order to withdraw unbonded.
        /// </summary>
        NotOnlyPoolMember,
        
        /// <summary>
        /// >> NotNominator
        /// The caller does not have nominating permissions for the pool.
        /// </summary>
        NotNominator,
        
        /// <summary>
        /// >> NotKickerOrDestroying
        /// Either a) the caller cannot make a valid kick or b) the pool is not destroying.
        /// </summary>
        NotKickerOrDestroying,
        
        /// <summary>
        /// >> NotOpen
        /// The pool is not open to join
        /// </summary>
        NotOpen,
        
        /// <summary>
        /// >> MaxPools
        /// The system is maxed out on pools.
        /// </summary>
        MaxPools,
        
        /// <summary>
        /// >> MaxPoolMembers
        /// Too many members in the pool or system.
        /// </summary>
        MaxPoolMembers,
        
        /// <summary>
        /// >> CanNotChangeState
        /// The pools state cannot be changed.
        /// </summary>
        CanNotChangeState,
        
        /// <summary>
        /// >> DoesNotHavePermission
        /// The caller does not have adequate permissions.
        /// </summary>
        DoesNotHavePermission,
        
        /// <summary>
        /// >> MetadataExceedsMaxLen
        /// Metadata exceeds [`Config::MaxMetadataLen`]
        /// </summary>
        MetadataExceedsMaxLen,
        
        /// <summary>
        /// >> DefensiveError
        /// Some error occurred that should never happen. This should be reported to the
        /// maintainers.
        /// </summary>
        DefensiveError,
        
        /// <summary>
        /// >> NotEnoughPointsToUnbond
        /// Not enough points. Ty unbonding less.
        /// </summary>
        NotEnoughPointsToUnbond,
        
        /// <summary>
        /// >> PartialUnbondNotAllowedPermissionlessly
        /// Partial unbonding now allowed permissionlessly.
        /// </summary>
        PartialUnbondNotAllowedPermissionlessly,
    }
}
