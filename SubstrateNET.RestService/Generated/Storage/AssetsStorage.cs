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
using SubstrateNET.NetApi.Generated.Model.PalletAssets;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAssetsStorage interface definition.
    /// </summary>
    public interface IAssetsStorage : IStorage
    {
        
        /// <summary>
        /// >> Asset
        ///  Details of an asset.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails GetAsset(string key);
        
        /// <summary>
        /// >> Account
        ///  The holdings of a specific account for a specific asset.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount GetAccount(string key);
        
        /// <summary>
        /// >> Approvals
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval GetApprovals(string key);
        
        /// <summary>
        /// >> Metadata
        ///  Metadata of an asset.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata GetMetadata(string key);
    }
    
    /// <summary>
    /// AssetsStorage class definition.
    /// </summary>
    public sealed class AssetsStorage : IAssetsStorage
    {
        
        /// <summary>
        /// _assetTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails> _assetTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount> _accountTypedStorage;
        
        /// <summary>
        /// _approvalsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval> _approvalsTypedStorage;
        
        /// <summary>
        /// _metadataTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata> _metadataTypedStorage;
        
        /// <summary>
        /// AssetsStorage constructor.
        /// </summary>
        public AssetsStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.AssetTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails>("Assets.Asset", storageDataProvider, storageChangeDelegate);
            this.AccountTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount>("Assets.Account", storageDataProvider, storageChangeDelegate);
            this.ApprovalsTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval>("Assets.Approvals", storageDataProvider, storageChangeDelegate);
            this.MetadataTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata>("Assets.Metadata", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _assetTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails> AssetTypedStorage
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
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount> AccountTypedStorage
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
        /// _approvalsTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval> ApprovalsTypedStorage
        {
            get
            {
                return _approvalsTypedStorage;
            }
            set
            {
                _approvalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _metadataTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata> MetadataTypedStorage
        {
            get
            {
                return _metadataTypedStorage;
            }
            set
            {
                _metadataTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AssetTypedStorage.InitializeAsync("Assets", "Asset");
            await AccountTypedStorage.InitializeAsync("Assets", "Account");
            await ApprovalsTypedStorage.InitializeAsync("Assets", "Approvals");
            await MetadataTypedStorage.InitializeAsync("Assets", "Metadata");
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Asset
        /// </summary>
        [StorageChange("Assets", "Asset")]
        public void OnUpdateAsset(string key, string data)
        {
            AssetTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Asset
        ///  Details of an asset.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails GetAsset(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Account
        /// </summary>
        [StorageChange("Assets", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The holdings of a specific account for a specific asset.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetAccount result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Approvals
        /// </summary>
        [StorageChange("Assets", "Approvals")]
        public void OnUpdateApprovals(string key, string data)
        {
            ApprovalsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Approvals
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval GetApprovals(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ApprovalsTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletAssets.Approval result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Metadata
        /// </summary>
        [StorageChange("Assets", "Metadata")]
        public void OnUpdateMetadata(string key, string data)
        {
            MetadataTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Metadata
        ///  Metadata of an asset.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata GetMetadata(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MetadataTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.PalletAssets.AssetMetadata result))
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
