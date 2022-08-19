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
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IStateTrieMigrationStorage interface definition.
    /// </summary>
    public interface IStateTrieMigrationStorage : IStorage
    {
        
        /// <summary>
        /// >> MigrationProcess
        ///  Migration progress.
        /// 
        ///  This stores the snapshot of the last migrated keys. It can be set into motion and move
        ///  forward by any of the means provided by this pallet.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask GetMigrationProcess();
        
        /// <summary>
        /// >> AutoLimits
        ///  The limits that are imposed on automatic migrations.
        /// 
        ///  If set to None, then no automatic migration happens.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> GetAutoLimits();
        
        /// <summary>
        /// >> SignedMigrationMaxLimits
        ///  The maximum limits that the signed migration could use.
        /// 
        ///  If not set, no signed submission is allowed.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits GetSignedMigrationMaxLimits();
    }
    
    /// <summary>
    /// StateTrieMigrationStorage class definition.
    /// </summary>
    public sealed class StateTrieMigrationStorage : IStateTrieMigrationStorage
    {
        
        /// <summary>
        /// _migrationProcessTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask> _migrationProcessTypedStorage;
        
        /// <summary>
        /// _autoLimitsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>> _autoLimitsTypedStorage;
        
        /// <summary>
        /// _signedMigrationMaxLimitsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> _signedMigrationMaxLimitsTypedStorage;
        
        /// <summary>
        /// StateTrieMigrationStorage constructor.
        /// </summary>
        public StateTrieMigrationStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MigrationProcessTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask>("StateTrieMigration.MigrationProcess", storageDataProvider, storageChangeDelegates);
            this.AutoLimitsTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>>("StateTrieMigration.AutoLimits", storageDataProvider, storageChangeDelegates);
            this.SignedMigrationMaxLimitsTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>("StateTrieMigration.SignedMigrationMaxLimits", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _migrationProcessTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask> MigrationProcessTypedStorage
        {
            get
            {
                return _migrationProcessTypedStorage;
            }
            set
            {
                _migrationProcessTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _autoLimitsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>> AutoLimitsTypedStorage
        {
            get
            {
                return _autoLimitsTypedStorage;
            }
            set
            {
                _autoLimitsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _signedMigrationMaxLimitsTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> SignedMigrationMaxLimitsTypedStorage
        {
            get
            {
                return _signedMigrationMaxLimitsTypedStorage;
            }
            set
            {
                _signedMigrationMaxLimitsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MigrationProcessTypedStorage.InitializeAsync("StateTrieMigration", "MigrationProcess");
            await AutoLimitsTypedStorage.InitializeAsync("StateTrieMigration", "AutoLimits");
            await SignedMigrationMaxLimitsTypedStorage.InitializeAsync("StateTrieMigration", "SignedMigrationMaxLimits");
        }
        
        /// <summary>
        /// Implements any storage change for StateTrieMigration.MigrationProcess
        /// </summary>
        [StorageChange("StateTrieMigration", "MigrationProcess")]
        public void OnUpdateMigrationProcess(string data)
        {
            MigrationProcessTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> MigrationProcess
        ///  Migration progress.
        /// 
        ///  This stores the snapshot of the last migrated keys. It can be set into motion and move
        ///  forward by any of the means provided by this pallet.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask GetMigrationProcess()
        {
            return MigrationProcessTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for StateTrieMigration.AutoLimits
        /// </summary>
        [StorageChange("StateTrieMigration", "AutoLimits")]
        public void OnUpdateAutoLimits(string data)
        {
            AutoLimitsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> AutoLimits
        ///  The limits that are imposed on automatic migrations.
        /// 
        ///  If set to None, then no automatic migration happens.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> GetAutoLimits()
        {
            return AutoLimitsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for StateTrieMigration.SignedMigrationMaxLimits
        /// </summary>
        [StorageChange("StateTrieMigration", "SignedMigrationMaxLimits")]
        public void OnUpdateSignedMigrationMaxLimits(string data)
        {
            SignedMigrationMaxLimitsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SignedMigrationMaxLimits
        ///  The maximum limits that the signed migration could use.
        /// 
        ///  If not set, no signed submission is allowed.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits GetSignedMigrationMaxLimits()
        {
            return SignedMigrationMaxLimitsTypedStorage.Get();
        }
    }
}
