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
    /// SchedulerController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class SchedulerController : ControllerBase
    {
        
        private ISchedulerStorage _schedulerStorage;
        
        /// <summary>
        /// SchedulerController constructor.
        /// </summary>
        public SchedulerController(ISchedulerStorage schedulerStorage)
        {
            _schedulerStorage = schedulerStorage;
        }
        
        /// <summary>
        /// >> IncompleteSince
        /// </summary>
        [HttpGet("IncompleteSince")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SchedulerStorage), "IncompleteSinceParams")]
        public IActionResult GetIncompleteSince()
        {
            return this.Ok(_schedulerStorage.GetIncompleteSince());
        }
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        [HttpGet("Agenda")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT31), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SchedulerStorage), "AgendaParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAgenda(string key)
        {
            return this.Ok(_schedulerStorage.GetAgenda(key));
        }
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from a name to the block number and index of the task.
        /// 
        ///  For v3 -> v4 the previously unbounded identities are Blake2-256 hashed to form the v4
        ///  identities.
        /// </summary>
        [HttpGet("Lookup")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SchedulerStorage), "LookupParams", typeof(SubstrateNET.NetApi.Generated.Types.Base.Arr32U8))]
        public IActionResult GetLookup(string key)
        {
            return this.Ok(_schedulerStorage.GetLookup(key));
        }
    }
}
