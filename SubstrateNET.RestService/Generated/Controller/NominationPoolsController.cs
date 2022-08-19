//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Microsoft.AspNetCore.Mvc;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// NominationPoolsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class NominationPoolsController : ControllerBase
    {
        
        private INominationPoolsStorage _nominationPoolsStorage;
        
        /// <summary>
        /// NominationPoolsController constructor.
        /// </summary>
        public NominationPoolsController(INominationPoolsStorage nominationPoolsStorage)
        {
            _nominationPoolsStorage = nominationPoolsStorage;
        }
        
        /// <summary>
        /// >> MinJoinBond
        ///  Minimum amount to bond to join a pool.
        /// </summary>
        [HttpGet("MinJoinBond")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MinJoinBondParams")]
        public IActionResult GetMinJoinBond()
        {
            return this.Ok(_nominationPoolsStorage.GetMinJoinBond());
        }
        
        /// <summary>
        /// >> MinCreateBond
        ///  Minimum bond required to create a pool.
        /// 
        ///  This is the amount that the depositor must put as their initial stake in the pool, as an
        ///  indication of "skin in the game".
        /// 
        ///  This is the value that will always exist in the staking ledger of the pool bonded account
        ///  while all other accounts leave.
        /// </summary>
        [HttpGet("MinCreateBond")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MinCreateBondParams")]
        public IActionResult GetMinCreateBond()
        {
            return this.Ok(_nominationPoolsStorage.GetMinCreateBond());
        }
        
        /// <summary>
        /// >> MaxPools
        ///  Maximum number of nomination pools that can exist. If `None`, then an unbounded number of
        ///  pools can exist.
        /// </summary>
        [HttpGet("MaxPools")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MaxPoolsParams")]
        public IActionResult GetMaxPools()
        {
            return this.Ok(_nominationPoolsStorage.GetMaxPools());
        }
        
        /// <summary>
        /// >> MaxPoolMembers
        ///  Maximum number of members that can exist in the system. If `None`, then the count
        ///  members are not bound on a system wide basis.
        /// </summary>
        [HttpGet("MaxPoolMembers")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MaxPoolMembersParams")]
        public IActionResult GetMaxPoolMembers()
        {
            return this.Ok(_nominationPoolsStorage.GetMaxPoolMembers());
        }
        
        /// <summary>
        /// >> MaxPoolMembersPerPool
        ///  Maximum number of members that may belong to pool. If `None`, then the count of
        ///  members is not bound on a per pool basis.
        /// </summary>
        [HttpGet("MaxPoolMembersPerPool")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MaxPoolMembersPerPoolParams")]
        public IActionResult GetMaxPoolMembersPerPool()
        {
            return this.Ok(_nominationPoolsStorage.GetMaxPoolMembersPerPool());
        }
        
        /// <summary>
        /// >> PoolMembers
        ///  Active members.
        /// </summary>
        [HttpGet("PoolMembers")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.PoolMember), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "PoolMembersParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetPoolMembers(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetPoolMembers(key));
        }
        
        /// <summary>
        /// >> CounterForPoolMembers
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForPoolMembers")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForPoolMembersParams")]
        public IActionResult GetCounterForPoolMembers()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForPoolMembers());
        }
        
        /// <summary>
        /// >> BondedPools
        ///  Storage for bonded pools.
        /// </summary>
        [HttpGet("BondedPools")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.BondedPoolInner), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "BondedPoolsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetBondedPools(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetBondedPools(key));
        }
        
        /// <summary>
        /// >> CounterForBondedPools
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForBondedPools")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForBondedPoolsParams")]
        public IActionResult GetCounterForBondedPools()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForBondedPools());
        }
        
        /// <summary>
        /// >> RewardPools
        ///  Reward pools. This is where there rewards for each pool accumulate. When a members payout
        ///  is claimed, the balance comes out fo the reward pool. Keyed by the bonded pools account.
        /// </summary>
        [HttpGet("RewardPools")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.RewardPool), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "RewardPoolsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetRewardPools(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetRewardPools(key));
        }
        
        /// <summary>
        /// >> CounterForRewardPools
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForRewardPools")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForRewardPoolsParams")]
        public IActionResult GetCounterForRewardPools()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForRewardPools());
        }
        
        /// <summary>
        /// >> SubPoolsStorage
        ///  Groups of unbonding pools. Each group of unbonding pools belongs to a bonded pool,
        ///  hence the name sub-pools. Keyed by the bonded pools account.
        /// </summary>
        [HttpGet("SubPoolsStorage")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.SubPools), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "SubPoolsStorageParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetSubPoolsStorage(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetSubPoolsStorage(key));
        }
        
        /// <summary>
        /// >> CounterForSubPoolsStorage
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForSubPoolsStorage")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForSubPoolsStorageParams")]
        public IActionResult GetCounterForSubPoolsStorage()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForSubPoolsStorage());
        }
        
        /// <summary>
        /// >> Metadata
        ///  Metadata for the pool.
        /// </summary>
        [HttpGet("Metadata")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT43), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "MetadataParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetMetadata(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetMetadata(key));
        }
        
        /// <summary>
        /// >> CounterForMetadata
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForMetadata")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForMetadataParams")]
        public IActionResult GetCounterForMetadata()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForMetadata());
        }
        
        /// <summary>
        /// >> LastPoolId
        ///  Ever increasing number of all pools created so far.
        /// </summary>
        [HttpGet("LastPoolId")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "LastPoolIdParams")]
        public IActionResult GetLastPoolId()
        {
            return this.Ok(_nominationPoolsStorage.GetLastPoolId());
        }
        
        /// <summary>
        /// >> ReversePoolIdLookup
        ///  A reverse lookup from the pool's account id to its id.
        /// 
        ///  This is only used for slashing. In all other instances, the pool id is used, and the
        ///  accounts are deterministically derived from it.
        /// </summary>
        [HttpGet("ReversePoolIdLookup")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "ReversePoolIdLookupParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetReversePoolIdLookup(string key)
        {
            return this.Ok(_nominationPoolsStorage.GetReversePoolIdLookup(key));
        }
        
        /// <summary>
        /// >> CounterForReversePoolIdLookup
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForReversePoolIdLookup")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage), "CounterForReversePoolIdLookupParams")]
        public IActionResult GetCounterForReversePoolIdLookup()
        {
            return this.Ok(_nominationPoolsStorage.GetCounterForReversePoolIdLookup());
        }
    }
}
