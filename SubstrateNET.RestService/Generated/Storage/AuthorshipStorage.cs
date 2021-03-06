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
using Ajuna.ServiceLayer.Storage;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAuthorshipStorage interface definition.
    /// </summary>
    public interface IAuthorshipStorage : IStorage
    {
        
        /// <summary>
        /// >> Uncles
        ///  Uncles
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT9 GetUncles();
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 GetAuthor();
        
        /// <summary>
        /// >> DidSetUncles
        ///  Whether uncles were already set in this block.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetDidSetUncles();
    }
    
    /// <summary>
    /// AuthorshipStorage class definition.
    /// </summary>
    public sealed class AuthorshipStorage : IAuthorshipStorage
    {
        
        /// <summary>
        /// _unclesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT9> _unclesTypedStorage;
        
        /// <summary>
        /// _authorTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> _authorTypedStorage;
        
        /// <summary>
        /// _didSetUnclesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _didSetUnclesTypedStorage;
        
        /// <summary>
        /// AuthorshipStorage constructor.
        /// </summary>
        public AuthorshipStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.UnclesTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT9>("Authorship.Uncles", storageDataProvider, storageChangeDelegate);
            this.AuthorTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32>("Authorship.Author", storageDataProvider, storageChangeDelegate);
            this.DidSetUnclesTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Authorship.DidSetUncles", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _unclesTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT9> UnclesTypedStorage
        {
            get
            {
                return _unclesTypedStorage;
            }
            set
            {
                _unclesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _authorTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> AuthorTypedStorage
        {
            get
            {
                return _authorTypedStorage;
            }
            set
            {
                _authorTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _didSetUnclesTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> DidSetUnclesTypedStorage
        {
            get
            {
                return _didSetUnclesTypedStorage;
            }
            set
            {
                _didSetUnclesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await UnclesTypedStorage.InitializeAsync("Authorship", "Uncles");
            await AuthorTypedStorage.InitializeAsync("Authorship", "Author");
            await DidSetUnclesTypedStorage.InitializeAsync("Authorship", "DidSetUncles");
        }
        
        /// <summary>
        /// Implements any storage change for Authorship.Uncles
        /// </summary>
        [StorageChange("Authorship", "Uncles")]
        public void OnUpdateUncles(string data)
        {
            UnclesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Uncles
        ///  Uncles
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT9 GetUncles()
        {
            return UnclesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Authorship.Author
        /// </summary>
        [StorageChange("Authorship", "Author")]
        public void OnUpdateAuthor(string data)
        {
            AuthorTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 GetAuthor()
        {
            return AuthorTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Authorship.DidSetUncles
        /// </summary>
        [StorageChange("Authorship", "DidSetUncles")]
        public void OnUpdateDidSetUncles(string data)
        {
            DidSetUnclesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DidSetUncles
        ///  Whether uncles were already set in this block.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetDidSetUncles()
        {
            return DidSetUnclesTypedStorage.Get();
        }
    }
}
