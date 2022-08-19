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
    /// SessionController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class SessionController : ControllerBase
    {
        
        private ISessionStorage _sessionStorage;
        
        /// <summary>
        /// SessionController constructor.
        /// </summary>
        public SessionController(ISessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        [HttpGet("Validators")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "ValidatorsParams")]
        public IActionResult GetValidators()
        {
            return this.Ok(_sessionStorage.GetValidators());
        }
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        [HttpGet("CurrentIndex")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "CurrentIndexParams")]
        public IActionResult GetCurrentIndex()
        {
            return this.Ok(_sessionStorage.GetCurrentIndex());
        }
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        [HttpGet("QueuedChanged")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "QueuedChangedParams")]
        public IActionResult GetQueuedChanged()
        {
            return this.Ok(_sessionStorage.GetQueuedChanged());
        }
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        [HttpGet("QueuedKeys")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.node_runtime.SessionKeys>>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "QueuedKeysParams")]
        public IActionResult GetQueuedKeys()
        {
            return this.Ok(_sessionStorage.GetQueuedKeys());
        }
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        [HttpGet("DisabledValidators")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "DisabledValidatorsParams")]
        public IActionResult GetDisabledValidators()
        {
            return this.Ok(_sessionStorage.GetDisabledValidators());
        }
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        [HttpGet("NextKeys")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.node_runtime.SessionKeys), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "NextKeysParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetNextKeys(string key)
        {
            return this.Ok(_sessionStorage.GetNextKeys(key));
        }
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        [HttpGet("KeyOwner")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.SessionStorage), "KeyOwnerParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.KeyTypeId, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>))]
        public IActionResult GetKeyOwner(string key)
        {
            return this.Ok(_sessionStorage.GetKeyOwner(key));
        }
    }
}
