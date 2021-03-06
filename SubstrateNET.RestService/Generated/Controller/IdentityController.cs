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
using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// IdentityController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class IdentityController : ControllerBase
    {
        
        private IIdentityStorage _identityStorage;
        
        /// <summary>
        /// IdentityController constructor.
        /// </summary>
        public IdentityController(IIdentityStorage identityStorage)
        {
            _identityStorage = identityStorage;
        }
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("IdentityOf")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletIdentity.Registration), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityStorage), "IdentityOfParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetIdentityOf(string key)
        {
            return this.Ok(_identityStorage.GetIdentityOf(key));
        }
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        [HttpGet("SuperOf")]
        [ProducesResponseType(typeof(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32,SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityStorage), "SuperOfParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetSuperOf(string key)
        {
            return this.Ok(_identityStorage.GetSuperOf(key));
        }
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("SubsOf")]
        [ProducesResponseType(typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128,SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT23>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityStorage), "SubsOfParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetSubsOf(string key)
        {
            return this.Ok(_identityStorage.GetSubsOf(key));
        }
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        [HttpGet("Registrars")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT24), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityStorage), "RegistrarsParams")]
        public IActionResult GetRegistrars()
        {
            return this.Ok(_identityStorage.GetRegistrars());
        }
    }
}
