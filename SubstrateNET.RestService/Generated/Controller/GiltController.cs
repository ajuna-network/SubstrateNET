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
    /// GiltController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class GiltController : ControllerBase
    {
        
        private IGiltStorage _giltStorage;
        
        /// <summary>
        /// GiltController constructor.
        /// </summary>
        public GiltController(IGiltStorage giltStorage)
        {
            _giltStorage = giltStorage;
        }
        
        /// <summary>
        /// >> QueueTotals
        ///  The totals of items and balances within each queue. Saves a lot of storage reads in the
        ///  case of sparsely packed queues.
        /// 
        ///  The vector is indexed by duration in `Period`s, offset by one, so information on the queue
        ///  whose duration is one `Period` would be storage `0`.
        /// </summary>
        [HttpGet("QueueTotals")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT37), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.GiltStorage), "QueueTotalsParams")]
        public IActionResult GetQueueTotals()
        {
            return this.Ok(_giltStorage.GetQueueTotals());
        }
        
        /// <summary>
        /// >> Queues
        ///  The queues of bids ready to become gilts. Indexed by duration (in `Period`s).
        /// </summary>
        [HttpGet("Queues")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT38), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.GiltStorage), "QueuesParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetQueues(string key)
        {
            return this.Ok(_giltStorage.GetQueues(key));
        }
        
        /// <summary>
        /// >> ActiveTotal
        ///  Information relating to the gilts currently active.
        /// </summary>
        [HttpGet("ActiveTotal")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.GiltStorage), "ActiveTotalParams")]
        public IActionResult GetActiveTotal()
        {
            return this.Ok(_giltStorage.GetActiveTotal());
        }
        
        /// <summary>
        /// >> Active
        ///  The currently active gilts, indexed according to the order of creation.
        /// </summary>
        [HttpGet("Active")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.GiltStorage), "ActiveParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetActive(string key)
        {
            return this.Ok(_giltStorage.GetActive(key));
        }
    }
}
