//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.ServiceLayer.Attributes;
using Microsoft.AspNetCore.Mvc;
using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
using SubstrateNET.NetApi.Generated.Model.PalletCollective;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// CouncilController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CouncilController : ControllerBase
    {
        
        private ICouncilStorage _councilStorage;
        
        /// <summary>
        /// CouncilController constructor.
        /// </summary>
        public CouncilController(ICouncilStorage councilStorage)
        {
            _councilStorage = councilStorage;
        }
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        [HttpGet("Proposals")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT13), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "ProposalsParams")]
        public IActionResult GetProposals()
        {
            return this.Ok(_councilStorage.GetProposals());
        }
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        [HttpGet("ProposalOf")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumNodeCall), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "ProposalOfParams", typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256))]
        public IActionResult GetProposalOf(string key)
        {
            return this.Ok(_councilStorage.GetProposalOf(key));
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        [HttpGet("Voting")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletCollective.Votes), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "VotingParams", typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256))]
        public IActionResult GetVoting(string key)
        {
            return this.Ok(_councilStorage.GetVoting(key));
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        [HttpGet("ProposalCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "ProposalCountParams")]
        public IActionResult GetProposalCount()
        {
            return this.Ok(_councilStorage.GetProposalCount());
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(BaseVec<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_councilStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletCouncil.CouncilStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_councilStorage.GetPrime());
        }
    }
}
