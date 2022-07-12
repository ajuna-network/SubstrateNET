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
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// RandomnessCollectiveFlipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class RandomnessCollectiveFlipController : ControllerBase
    {
        
        private IRandomnessCollectiveFlipStorage _randomnessCollectiveFlipStorage;
        
        /// <summary>
        /// RandomnessCollectiveFlipController constructor.
        /// </summary>
        public RandomnessCollectiveFlipController(IRandomnessCollectiveFlipStorage randomnessCollectiveFlipStorage)
        {
            _randomnessCollectiveFlipStorage = randomnessCollectiveFlipStorage;
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        [HttpGet("RandomMaterial")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT21), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletRandomnessCollectiveFlip.RandomnessCollectiveFlipStorage), "RandomMaterialParams")]
        public IActionResult GetRandomMaterial()
        {
            return this.Ok(_randomnessCollectiveFlipStorage.GetRandomMaterial());
        }
    }
}
