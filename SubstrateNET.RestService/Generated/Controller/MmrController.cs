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
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// MmrController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class MmrController : ControllerBase
    {
        
        private IMmrStorage _mmrStorage;
        
        /// <summary>
        /// MmrController constructor.
        /// </summary>
        public MmrController(IMmrStorage mmrStorage)
        {
            _mmrStorage = mmrStorage;
        }
        
        /// <summary>
        /// >> RootHash
        ///  Latest MMR Root hash.
        /// </summary>
        [HttpGet("RootHash")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletMmr.MmrStorage), "RootHashParams")]
        public IActionResult GetRootHash()
        {
            return this.Ok(_mmrStorage.GetRootHash());
        }
        
        /// <summary>
        /// >> NumberOfLeaves
        ///  Current size of the MMR (number of leaves).
        /// </summary>
        [HttpGet("NumberOfLeaves")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletMmr.MmrStorage), "NumberOfLeavesParams")]
        public IActionResult GetNumberOfLeaves()
        {
            return this.Ok(_mmrStorage.GetNumberOfLeaves());
        }
        
        /// <summary>
        /// >> Nodes
        ///  Hashes of the nodes in the MMR.
        /// 
        ///  Note this collection only contains MMR peaks, the inner nodes (and leaves)
        ///  are pruned and only stored in the Offchain DB.
        /// </summary>
        [HttpGet("Nodes")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletMmr.MmrStorage), "NodesParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U64))]
        public IActionResult GetNodes(string key)
        {
            return this.Ok(_mmrStorage.GetNodes(key));
        }
    }
}
