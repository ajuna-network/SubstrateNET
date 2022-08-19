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
    /// AuthorshipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuthorshipController : ControllerBase
    {
        
        private IAuthorshipStorage _authorshipStorage;
        
        /// <summary>
        /// AuthorshipController constructor.
        /// </summary>
        public AuthorshipController(IAuthorshipStorage authorshipStorage)
        {
            _authorshipStorage = authorshipStorage;
        }
        
        /// <summary>
        /// >> Uncles
        ///  Uncles
        /// </summary>
        [HttpGet("Uncles")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT9), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AuthorshipStorage), "UnclesParams")]
        public IActionResult GetUncles()
        {
            return this.Ok(_authorshipStorage.GetUncles());
        }
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        [HttpGet("Author")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AuthorshipStorage), "AuthorParams")]
        public IActionResult GetAuthor()
        {
            return this.Ok(_authorshipStorage.GetAuthor());
        }
        
        /// <summary>
        /// >> DidSetUncles
        ///  Whether uncles were already set in this block.
        /// </summary>
        [HttpGet("DidSetUncles")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AuthorshipStorage), "DidSetUnclesParams")]
        public IActionResult GetDidSetUncles()
        {
            return this.Ok(_authorshipStorage.GetDidSetUncles());
        }
    }
}
