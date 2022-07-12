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
using SubstrateNET.NetApi.Generated.Model.FrameSupport;
using SubstrateNET.NetApi.Generated.Model.PalletUniques;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IUniquesStorage interface definition.
    /// </summary>
    public interface IUniquesStorage : IStorage
    {
        
        /// <summary>
        /// >> Class
        ///  Details of a collection.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails GetClass(string key);
        
        /// <summary>
        /// >> OwnershipAcceptance
        ///  The collection, if any, of which an account is willing to take ownership.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetOwnershipAcceptance(string key);
        
        /// <summary>
        /// >> Account
        ///  The items held by any given account; set out this way so that items owned by a single
        ///  account can be enumerated.
        /// </summary>
        BaseTuple GetAccount(string key);
        
        /// <summary>
        /// >> ClassAccount
        ///  The collections owned by any given account; set out this way so that collections owned by
        ///  a single account can be enumerated.
        /// </summary>
        BaseTuple GetClassAccount(string key);
        
        /// <summary>
        /// >> Asset
        ///  The items in existence and their ownership details.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails GetAsset(string key);
        
        /// <summary>
        /// >> ClassMetadataOf
        ///  Metadata of a collection.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata GetClassMetadataOf(string key);
        
        /// <summary>
        /// >> InstanceMetadataOf
        ///  Metadata of an item.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata GetInstanceMetadataOf(string key);
        
        /// <summary>
        /// >> Attribute
        ///  Attributes of a collection.
        /// </summary>
        BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128> GetAttribute(string key);
        
        /// <summary>
        /// >> CollectionMaxSupply
        ///  Keeps track of the number of items a collection might have.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetCollectionMaxSupply(string key);
    }
    
    /// <summary>
    /// UniquesStorage class definition.
    /// </summary>
    public sealed class UniquesStorage : IUniquesStorage
    {
        
        /// <summary>
        /// _classTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails> _classTypedStorage;
        
        /// <summary>
        /// _ownershipAcceptanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _ownershipAcceptanceTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple> _accountTypedStorage;
        
        /// <summary>
        /// _classAccountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple> _classAccountTypedStorage;
        
        /// <summary>
        /// _assetTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails> _assetTypedStorage;
        
        /// <summary>
        /// _classMetadataOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata> _classMetadataOfTypedStorage;
        
        /// <summary>
        /// _instanceMetadataOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata> _instanceMetadataOfTypedStorage;
        
        /// <summary>
        /// _attributeTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128>> _attributeTypedStorage;
        
        /// <summary>
        /// _collectionMaxSupplyTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _collectionMaxSupplyTypedStorage;
        
        /// <summary>
        /// UniquesStorage constructor.
        /// </summary>
        public UniquesStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.ClassTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails>("Uniques.Class", storageDataProvider, storageChangeDelegate);
            this.OwnershipAcceptanceTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Uniques.OwnershipAcceptance", storageDataProvider, storageChangeDelegate);
            this.AccountTypedStorage = new TypedMapStorage<BaseTuple>("Uniques.Account", storageDataProvider, storageChangeDelegate);
            this.ClassAccountTypedStorage = new TypedMapStorage<BaseTuple>("Uniques.ClassAccount", storageDataProvider, storageChangeDelegate);
            this.AssetTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails>("Uniques.Asset", storageDataProvider, storageChangeDelegate);
            this.ClassMetadataOfTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata>("Uniques.ClassMetadataOf", storageDataProvider, storageChangeDelegate);
            this.InstanceMetadataOfTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata>("Uniques.InstanceMetadataOf", storageDataProvider, storageChangeDelegate);
            this.AttributeTypedStorage = new TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128>>("Uniques.Attribute", storageDataProvider, storageChangeDelegate);
            this.CollectionMaxSupplyTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Uniques.CollectionMaxSupply", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _classTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails> ClassTypedStorage
        {
            get
            {
                return _classTypedStorage;
            }
            set
            {
                _classTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownershipAcceptanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> OwnershipAcceptanceTypedStorage
        {
            get
            {
                return _ownershipAcceptanceTypedStorage;
            }
            set
            {
                _ownershipAcceptanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _classAccountTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple> ClassAccountTypedStorage
        {
            get
            {
                return _classAccountTypedStorage;
            }
            set
            {
                _classAccountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _assetTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails> AssetTypedStorage
        {
            get
            {
                return _assetTypedStorage;
            }
            set
            {
                _assetTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _classMetadataOfTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata> ClassMetadataOfTypedStorage
        {
            get
            {
                return _classMetadataOfTypedStorage;
            }
            set
            {
                _classMetadataOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _instanceMetadataOfTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata> InstanceMetadataOfTypedStorage
        {
            get
            {
                return _instanceMetadataOfTypedStorage;
            }
            set
            {
                _instanceMetadataOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _attributeTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128>> AttributeTypedStorage
        {
            get
            {
                return _attributeTypedStorage;
            }
            set
            {
                _attributeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionMaxSupplyTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> CollectionMaxSupplyTypedStorage
        {
            get
            {
                return _collectionMaxSupplyTypedStorage;
            }
            set
            {
                _collectionMaxSupplyTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ClassTypedStorage.InitializeAsync("Uniques", "Class");
            await OwnershipAcceptanceTypedStorage.InitializeAsync("Uniques", "OwnershipAcceptance");
            await AccountTypedStorage.InitializeAsync("Uniques", "Account");
            await ClassAccountTypedStorage.InitializeAsync("Uniques", "ClassAccount");
            await AssetTypedStorage.InitializeAsync("Uniques", "Asset");
            await ClassMetadataOfTypedStorage.InitializeAsync("Uniques", "ClassMetadataOf");
            await InstanceMetadataOfTypedStorage.InitializeAsync("Uniques", "InstanceMetadataOf");
            await AttributeTypedStorage.InitializeAsync("Uniques", "Attribute");
            await CollectionMaxSupplyTypedStorage.InitializeAsync("Uniques", "CollectionMaxSupply");
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.Class
        /// </summary>
        [StorageChange("Uniques", "Class")]
        public void OnUpdateClass(string key, string data)
        {
            ClassTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Class
        ///  Details of a collection.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails GetClass(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ClassTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.OwnershipAcceptance
        /// </summary>
        [StorageChange("Uniques", "OwnershipAcceptance")]
        public void OnUpdateOwnershipAcceptance(string key, string data)
        {
            OwnershipAcceptanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> OwnershipAcceptance
        ///  The collection, if any, of which an account is willing to take ownership.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetOwnershipAcceptance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnershipAcceptanceTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.Account
        /// </summary>
        [StorageChange("Uniques", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The items held by any given account; set out this way so that items owned by a single
        ///  account can be enumerated.
        /// </summary>
        public BaseTuple GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out BaseTuple result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.ClassAccount
        /// </summary>
        [StorageChange("Uniques", "ClassAccount")]
        public void OnUpdateClassAccount(string key, string data)
        {
            ClassAccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ClassAccount
        ///  The collections owned by any given account; set out this way so that collections owned by
        ///  a single account can be enumerated.
        /// </summary>
        public BaseTuple GetClassAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ClassAccountTypedStorage.Dictionary.TryGetValue(key, out BaseTuple result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.Asset
        /// </summary>
        [StorageChange("Uniques", "Asset")]
        public void OnUpdateAsset(string key, string data)
        {
            AssetTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Asset
        ///  The items in existence and their ownership details.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails GetAsset(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.ClassMetadataOf
        /// </summary>
        [StorageChange("Uniques", "ClassMetadataOf")]
        public void OnUpdateClassMetadataOf(string key, string data)
        {
            ClassMetadataOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ClassMetadataOf
        ///  Metadata of a collection.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata GetClassMetadataOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ClassMetadataOfTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletUniques.CollectionMetadata result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.InstanceMetadataOf
        /// </summary>
        [StorageChange("Uniques", "InstanceMetadataOf")]
        public void OnUpdateInstanceMetadataOf(string key, string data)
        {
            InstanceMetadataOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> InstanceMetadataOf
        ///  Metadata of an item.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata GetInstanceMetadataOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (InstanceMetadataOfTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletUniques.ItemMetadata result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.Attribute
        /// </summary>
        [StorageChange("Uniques", "Attribute")]
        public void OnUpdateAttribute(string key, string data)
        {
            AttributeTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Attribute
        ///  Attributes of a collection.
        /// </summary>
        public BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128> GetAttribute(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AttributeTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3,Ajuna.NetApi.Model.Types.Primitive.U128> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Uniques.CollectionMaxSupply
        /// </summary>
        [StorageChange("Uniques", "CollectionMaxSupply")]
        public void OnUpdateCollectionMaxSupply(string key, string data)
        {
            CollectionMaxSupplyTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionMaxSupply
        ///  Keeps track of the number of items a collection might have.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetCollectionMaxSupply(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionMaxSupplyTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
