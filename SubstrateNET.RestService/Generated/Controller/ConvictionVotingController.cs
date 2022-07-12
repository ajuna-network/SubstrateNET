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
using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ConvictionVotingController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ConvictionVotingController : ControllerBase
    {
        
        private IConvictionVotingStorage _convictionVotingStorage;
        
        /// <summary>
        /// ConvictionVotingController constructor.
        /// </summary>
        public ConvictionVotingController(IConvictionVotingStorage convictionVotingStorage)
        {
            _convictionVotingStorage = convictionVotingStorage;
        }
        
        /// <summary>
        /// >> VotingFor
        ///  All voting for a particular voter in a particular voting class. We store the balance for the
        ///  number of votes that we have recorded.
        /// </summary>
        [HttpGet("VotingFor")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.EnumVoting), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.ConvictionVotingStorage), "VotingForParams", typeof(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U8>))]
        public IActionResult GetVotingFor(string key)
        {
            return this.Ok(_convictionVotingStorage.GetVotingFor(key));
        }
        
        /// <summary>
        /// >> ClassLocksFor
        ///  The voting classes which have a non-zero lock requirement and the lock amounts which they
        ///  require. The actual amount locked on behalf of this pallet should always be the maximum of
        ///  this list.
        /// </summary>
        [HttpGet("ClassLocksFor")]
        [ProducesResponseType(typeof(BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8,Ajuna.NetApi.Model.Types.Primitive.U128>>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.ConvictionVotingStorage), "ClassLocksForParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetClassLocksFor(string key)
        {
            return this.Ok(_convictionVotingStorage.GetClassLocksFor(key));
        }
    }
}
