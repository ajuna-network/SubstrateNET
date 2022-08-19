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
    /// WhitelistController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class WhitelistController : ControllerBase
    {
        
        private IWhitelistStorage _whitelistStorage;
        
        /// <summary>
        /// WhitelistController constructor.
        /// </summary>
        public WhitelistController(IWhitelistStorage whitelistStorage)
        {
            _whitelistStorage = whitelistStorage;
        }
        
        /// <summary>
        /// >> WhitelistedCall
        /// </summary>
        [HttpGet("WhitelistedCall")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.WhitelistStorage), "WhitelistedCallParams", typeof(SubstrateNET.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetWhitelistedCall(string key)
        {
            return this.Ok(_whitelistStorage.GetWhitelistedCall(key));
        }
    }
}
