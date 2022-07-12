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
using SubstrateNET.NetApi.Generated.Model.PalletGrandpa;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// GrandpaController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class GrandpaController : ControllerBase
    {
        
        private IGrandpaStorage _grandpaStorage;
        
        /// <summary>
        /// GrandpaController constructor.
        /// </summary>
        public GrandpaController(IGrandpaStorage grandpaStorage)
        {
            _grandpaStorage = grandpaStorage;
        }
        
        /// <summary>
        /// >> State
        ///  State of the current authority set.
        /// </summary>
        [HttpGet("State")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.EnumStoredState), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "StateParams")]
        public IActionResult GetState()
        {
            return this.Ok(_grandpaStorage.GetState());
        }
        
        /// <summary>
        /// >> PendingChange
        ///  Pending change: (signaled at, scheduled change).
        /// </summary>
        [HttpGet("PendingChange")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.StoredPendingChange), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "PendingChangeParams")]
        public IActionResult GetPendingChange()
        {
            return this.Ok(_grandpaStorage.GetPendingChange());
        }
        
        /// <summary>
        /// >> NextForced
        ///  next block number where we can force a change.
        /// </summary>
        [HttpGet("NextForced")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "NextForcedParams")]
        public IActionResult GetNextForced()
        {
            return this.Ok(_grandpaStorage.GetNextForced());
        }
        
        /// <summary>
        /// >> Stalled
        ///  `true` if we are currently stalled.
        /// </summary>
        [HttpGet("Stalled")]
        [ProducesResponseType(typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "StalledParams")]
        public IActionResult GetStalled()
        {
            return this.Ok(_grandpaStorage.GetStalled());
        }
        
        /// <summary>
        /// >> CurrentSetId
        ///  The number of changes (both in terms of keys and underlying economic responsibilities)
        ///  in the "set" of Grandpa validators from genesis.
        /// </summary>
        [HttpGet("CurrentSetId")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "CurrentSetIdParams")]
        public IActionResult GetCurrentSetId()
        {
            return this.Ok(_grandpaStorage.GetCurrentSetId());
        }
        
        /// <summary>
        /// >> SetIdSession
        ///  A mapping from grandpa set ID to the index of the *most recent* session for which its
        ///  members were responsible.
        /// 
        ///  TWOX-NOTE: `SetId` is not under user control.
        /// </summary>
        [HttpGet("SetIdSession")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage), "SetIdSessionParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U64))]
        public IActionResult GetSetIdSession(string key)
        {
            return this.Ok(_grandpaStorage.GetSetIdSession(key));
        }
    }
}
