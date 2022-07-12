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
using SubstrateNET.NetApi.Generated.Model.PalletBagsList;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BagsListController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BagsListController : ControllerBase
    {
        
        private IBagsListStorage _bagsListStorage;
        
        /// <summary>
        /// BagsListController constructor.
        /// </summary>
        public BagsListController(IBagsListStorage bagsListStorage)
        {
            _bagsListStorage = bagsListStorage;
        }
        
        /// <summary>
        /// >> ListNodes
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        [HttpGet("ListNodes")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.Node), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.BagsListStorage), "ListNodesParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetListNodes(string key)
        {
            return this.Ok(_bagsListStorage.GetListNodes(key));
        }
        
        /// <summary>
        /// >> CounterForListNodes
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForListNodes")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.BagsListStorage), "CounterForListNodesParams")]
        public IActionResult GetCounterForListNodes()
        {
            return this.Ok(_bagsListStorage.GetCounterForListNodes());
        }
        
        /// <summary>
        /// >> ListBags
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        [HttpGet("ListBags")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.Bag), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.BagsListStorage), "ListBagsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U64))]
        public IActionResult GetListBags(string key)
        {
            return this.Ok(_bagsListStorage.GetListBags(key));
        }
    }
}
