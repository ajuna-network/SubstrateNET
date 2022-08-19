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
    /// IContractsStorage interface definition.
    /// </summary>
    public interface IContractsStorage : IStorage
    {
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 GetPristineCode(string key);
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule GetCodeStorage(string key);
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo GetOwnerInfoOf(string key);
        
        /// <summary>
        /// >> Nonce
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U64 GetNonce();
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo GetContractInfoOf(string key);
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 GetDeletionQueue();
    }
    
    /// <summary>
    /// ContractsStorage class definition.
    /// </summary>
    public sealed class ContractsStorage : IContractsStorage
    {
        
        /// <summary>
        /// _pristineCodeTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17> _pristineCodeTypedStorage;
        
        /// <summary>
        /// _codeStorageTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule> _codeStorageTypedStorage;
        
        /// <summary>
        /// _ownerInfoOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo> _ownerInfoOfTypedStorage;
        
        /// <summary>
        /// _nonceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> _nonceTypedStorage;
        
        /// <summary>
        /// _contractInfoOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo> _contractInfoOfTypedStorage;
        
        /// <summary>
        /// _deletionQueueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20> _deletionQueueTypedStorage;
        
        /// <summary>
        /// ContractsStorage constructor.
        /// </summary>
        public ContractsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.PristineCodeTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17>("Contracts.PristineCode", storageDataProvider, storageChangeDelegates);
            this.CodeStorageTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule>("Contracts.CodeStorage", storageDataProvider, storageChangeDelegates);
            this.OwnerInfoOfTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo>("Contracts.OwnerInfoOf", storageDataProvider, storageChangeDelegates);
            this.NonceTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64>("Contracts.Nonce", storageDataProvider, storageChangeDelegates);
            this.ContractInfoOfTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo>("Contracts.ContractInfoOf", storageDataProvider, storageChangeDelegates);
            this.DeletionQueueTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20>("Contracts.DeletionQueue", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _pristineCodeTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17> PristineCodeTypedStorage
        {
            get
            {
                return _pristineCodeTypedStorage;
            }
            set
            {
                _pristineCodeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _codeStorageTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule> CodeStorageTypedStorage
        {
            get
            {
                return _codeStorageTypedStorage;
            }
            set
            {
                _codeStorageTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownerInfoOfTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo> OwnerInfoOfTypedStorage
        {
            get
            {
                return _ownerInfoOfTypedStorage;
            }
            set
            {
                _ownerInfoOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nonceTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> NonceTypedStorage
        {
            get
            {
                return _nonceTypedStorage;
            }
            set
            {
                _nonceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _contractInfoOfTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo> ContractInfoOfTypedStorage
        {
            get
            {
                return _contractInfoOfTypedStorage;
            }
            set
            {
                _contractInfoOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deletionQueueTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20> DeletionQueueTypedStorage
        {
            get
            {
                return _deletionQueueTypedStorage;
            }
            set
            {
                _deletionQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await PristineCodeTypedStorage.InitializeAsync("Contracts", "PristineCode");
            await CodeStorageTypedStorage.InitializeAsync("Contracts", "CodeStorage");
            await OwnerInfoOfTypedStorage.InitializeAsync("Contracts", "OwnerInfoOf");
            await NonceTypedStorage.InitializeAsync("Contracts", "Nonce");
            await ContractInfoOfTypedStorage.InitializeAsync("Contracts", "ContractInfoOf");
            await DeletionQueueTypedStorage.InitializeAsync("Contracts", "DeletionQueue");
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.PristineCode
        /// </summary>
        [StorageChange("Contracts", "PristineCode")]
        public void OnUpdatePristineCode(string key, string data)
        {
            PristineCodeTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 GetPristineCode(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PristineCodeTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.CodeStorage
        /// </summary>
        [StorageChange("Contracts", "CodeStorage")]
        public void OnUpdateCodeStorage(string key, string data)
        {
            CodeStorageTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule GetCodeStorage(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CodeStorageTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.OwnerInfoOf
        /// </summary>
        [StorageChange("Contracts", "OwnerInfoOf")]
        public void OnUpdateOwnerInfoOf(string key, string data)
        {
            OwnerInfoOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo GetOwnerInfoOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnerInfoOfTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.Nonce
        /// </summary>
        [StorageChange("Contracts", "Nonce")]
        public void OnUpdateNonce(string data)
        {
            NonceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Nonce
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U64 GetNonce()
        {
            return NonceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.ContractInfoOf
        /// </summary>
        [StorageChange("Contracts", "ContractInfoOf")]
        public void OnUpdateContractInfoOf(string key, string data)
        {
            ContractInfoOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo GetContractInfoOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ContractInfoOfTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Contracts.DeletionQueue
        /// </summary>
        [StorageChange("Contracts", "DeletionQueue")]
        public void OnUpdateDeletionQueue(string data)
        {
            DeletionQueueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 GetDeletionQueue()
        {
            return DeletionQueueTypedStorage.Get();
        }
    }
}
