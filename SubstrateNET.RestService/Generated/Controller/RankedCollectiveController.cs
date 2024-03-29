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
    /// RankedCollectiveController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class RankedCollectiveController : ControllerBase
    {
        
        private IRankedCollectiveStorage _rankedCollectiveStorage;
        
        /// <summary>
        /// RankedCollectiveController constructor.
        /// </summary>
        public RankedCollectiveController(IRankedCollectiveStorage rankedCollectiveStorage)
        {
            _rankedCollectiveStorage = rankedCollectiveStorage;
        }
        
        /// <summary>
        /// >> MemberCount
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        [HttpGet("MemberCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "MemberCountParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetMemberCount(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetMemberCount(key));
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.MemberRecord), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "MembersParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetMembers(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetMembers(key));
        }
        
        /// <summary>
        /// >> IdToIndex
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        [HttpGet("IdToIndex")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "IdToIndexParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetIdToIndex(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetIdToIndex(key));
        }
        
        /// <summary>
        /// >> IndexToId
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        [HttpGet("IndexToId")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "IndexToIdParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetIndexToId(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetIndexToId(key));
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        [HttpGet("Voting")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.EnumVoteRecord), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "VotingParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetVoting(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetVoting(key));
        }
        
        /// <summary>
        /// >> VotingCleanup
        /// </summary>
        [HttpGet("VotingCleanup")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT49), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.RankedCollectiveStorage), "VotingCleanupParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetVotingCleanup(string key)
        {
            return this.Ok(_rankedCollectiveStorage.GetVotingCleanup(key));
        }
    }
}
