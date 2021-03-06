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
using SubstrateNET.NetApi.Generated.Model.PalletUniques;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// UniquesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class UniquesController : ControllerBase
    {
        
        private IUniquesStorage _uniquesStorage;
        
        /// <summary>
        /// UniquesController constructor.
        /// </summary>
        public UniquesController(IUniquesStorage uniquesStorage)
        {
            _uniquesStorage = uniquesStorage;
        }
        
        /// <summary>
        /// >> Class
        ///  Details of a collection.
        /// </summary>
        [HttpGet("Class")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "ClassParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetClass(string key)
        {
            return this.Ok(_uniquesStorage.GetClass(key));
        }
        
        /// <summary>
        /// >> OwnershipAcceptance
        ///  The collection, if any, of which an account is willing to take ownership.
        /// </summary>
        [HttpGet("OwnershipAcceptance")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "OwnershipAcceptanceParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetOwnershipAcceptance(string key)
        {
            return this.Ok(_uniquesStorage.GetOwnershipAcceptance(key));
        }
        
        /// <summary>
        /// >> Account
        ///  The items held by any given account; set out this way so that items owned by a single
        ///  account can be enumerated.
        /// </summary>
        [HttpGet("Account")]
        [ProducesResponseType(typeof(BaseTuple), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "AccountParams", typeof(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetAccount(string key)
        {
            return this.Ok(_uniquesStorage.GetAccount(key));
        }
        
        /// <summary>
        /// >> ClassAccount
        ///  The collections owned by any given account; set out this way so that collections owned by
        ///  a single account can be enumerated.
        /// </summary>
        [HttpGet("ClassAccount")]
        [ProducesResponseType(typeof(BaseTuple), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "ClassAccountParams", typeof(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetClassAccount(string key)
        {
            return this.Ok(_uniquesStorage.GetClassAccount(key));
        }
        
        /// <summary>
        /// >> Asset
        ///  The items in existence and their ownership details.
        /// </summary>
        [HttpGet("Asset")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "AssetParams", typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetAsset(string key)
        {
            return this.Ok(_uniquesStorage.GetAsset(key));
        }
        
        /// <summary>
        /// >> ClassMetadataOf
        ///  Metadata of a collection.
        /// </summary>
        [HttpGet("ClassMetadataOf")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "ClassMetadataOfParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetClassMetadataOf(string key)
        {
            return this.Ok(_uniquesStorage.GetClassMetadataOf(key));
        }
        
        /// <summary>
        /// >> InstanceMetadataOf
        ///  Metadata of an item.
        /// </summary>
        [HttpGet("InstanceMetadataOf")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "InstanceMetadataOfParams", typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetInstanceMetadataOf(string key)
        {
            return this.Ok(_uniquesStorage.GetInstanceMetadataOf(key));
        }
        
        /// <summary>
        /// >> Attribute
        ///  Attributes of a collection.
        /// </summary>
        [HttpGet("Attribute")]
        [ProducesResponseType(typeof(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "AttributeParams", typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT2>))]
        public IActionResult GetAttribute(string key)
        {
            return this.Ok(_uniquesStorage.GetAttribute(key));
        }
        
        /// <summary>
        /// >> CollectionMaxSupply
        ///  Keeps track of the number of items a collection might have.
        /// </summary>
        [HttpGet("CollectionMaxSupply")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletUniques.UniquesStorage), "CollectionMaxSupplyParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetCollectionMaxSupply(string key)
        {
            return this.Ok(_uniquesStorage.GetCollectionMaxSupply(key));
        }
    }
}
