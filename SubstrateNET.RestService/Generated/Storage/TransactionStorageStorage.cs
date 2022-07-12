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
using SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITransactionStorageStorage interface definition.
    /// </summary>
    public interface ITransactionStorageStorage : IStorage
    {
        
        /// <summary>
        /// >> Transactions
        ///  Collection of transaction metadata by block number.
        /// </summary>
        BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo> GetTransactions(string key);
        
        /// <summary>
        /// >> ChunkCount
        ///  Count indexed chunks for each block.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetChunkCount(string key);
        
        /// <summary>
        /// >> ByteFee
        ///  Storage fee per byte.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetByteFee();
        
        /// <summary>
        /// >> EntryFee
        ///  Storage fee per transaction.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetEntryFee();
        
        /// <summary>
        /// >> MaxTransactionSize
        ///  Maximum data set in a single transaction in bytes.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetMaxTransactionSize();
        
        /// <summary>
        /// >> MaxBlockTransactions
        ///  Maximum number of indexed transactions in the block.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetMaxBlockTransactions();
        
        /// <summary>
        /// >> StoragePeriod
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetStoragePeriod();
        
        /// <summary>
        /// >> BlockTransactions
        /// </summary>
        BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo> GetBlockTransactions();
        
        /// <summary>
        /// >> ProofChecked
        ///  Was the proof checked in this block?
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetProofChecked();
    }
    
    /// <summary>
    /// TransactionStorageStorage class definition.
    /// </summary>
    public sealed class TransactionStorageStorage : ITransactionStorageStorage
    {
        
        /// <summary>
        /// _transactionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>> _transactionsTypedStorage;
        
        /// <summary>
        /// _chunkCountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _chunkCountTypedStorage;
        
        /// <summary>
        /// _byteFeeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _byteFeeTypedStorage;
        
        /// <summary>
        /// _entryFeeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _entryFeeTypedStorage;
        
        /// <summary>
        /// _maxTransactionSizeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _maxTransactionSizeTypedStorage;
        
        /// <summary>
        /// _maxBlockTransactionsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _maxBlockTransactionsTypedStorage;
        
        /// <summary>
        /// _storagePeriodTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _storagePeriodTypedStorage;
        
        /// <summary>
        /// _blockTransactionsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>> _blockTransactionsTypedStorage;
        
        /// <summary>
        /// _proofCheckedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _proofCheckedTypedStorage;
        
        /// <summary>
        /// TransactionStorageStorage constructor.
        /// </summary>
        public TransactionStorageStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.TransactionsTypedStorage = new TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>>("TransactionStorage.Transactions", storageDataProvider, storageChangeDelegate);
            this.ChunkCountTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("TransactionStorage.ChunkCount", storageDataProvider, storageChangeDelegate);
            this.ByteFeeTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("TransactionStorage.ByteFee", storageDataProvider, storageChangeDelegate);
            this.EntryFeeTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("TransactionStorage.EntryFee", storageDataProvider, storageChangeDelegate);
            this.MaxTransactionSizeTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("TransactionStorage.MaxTransactionSize", storageDataProvider, storageChangeDelegate);
            this.MaxBlockTransactionsTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("TransactionStorage.MaxBlockTransactions", storageDataProvider, storageChangeDelegate);
            this.StoragePeriodTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("TransactionStorage.StoragePeriod", storageDataProvider, storageChangeDelegate);
            this.BlockTransactionsTypedStorage = new TypedStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>>("TransactionStorage.BlockTransactions", storageDataProvider, storageChangeDelegate);
            this.ProofCheckedTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("TransactionStorage.ProofChecked", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _transactionsTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>> TransactionsTypedStorage
        {
            get
            {
                return _transactionsTypedStorage;
            }
            set
            {
                _transactionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _chunkCountTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ChunkCountTypedStorage
        {
            get
            {
                return _chunkCountTypedStorage;
            }
            set
            {
                _chunkCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _byteFeeTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> ByteFeeTypedStorage
        {
            get
            {
                return _byteFeeTypedStorage;
            }
            set
            {
                _byteFeeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _entryFeeTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> EntryFeeTypedStorage
        {
            get
            {
                return _entryFeeTypedStorage;
            }
            set
            {
                _entryFeeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _maxTransactionSizeTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> MaxTransactionSizeTypedStorage
        {
            get
            {
                return _maxTransactionSizeTypedStorage;
            }
            set
            {
                _maxTransactionSizeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _maxBlockTransactionsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> MaxBlockTransactionsTypedStorage
        {
            get
            {
                return _maxBlockTransactionsTypedStorage;
            }
            set
            {
                _maxBlockTransactionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storagePeriodTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> StoragePeriodTypedStorage
        {
            get
            {
                return _storagePeriodTypedStorage;
            }
            set
            {
                _storagePeriodTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blockTransactionsTypedStorage property
        /// </summary>
        public TypedStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo>> BlockTransactionsTypedStorage
        {
            get
            {
                return _blockTransactionsTypedStorage;
            }
            set
            {
                _blockTransactionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proofCheckedTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> ProofCheckedTypedStorage
        {
            get
            {
                return _proofCheckedTypedStorage;
            }
            set
            {
                _proofCheckedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TransactionsTypedStorage.InitializeAsync("TransactionStorage", "Transactions");
            await ChunkCountTypedStorage.InitializeAsync("TransactionStorage", "ChunkCount");
            await ByteFeeTypedStorage.InitializeAsync("TransactionStorage", "ByteFee");
            await EntryFeeTypedStorage.InitializeAsync("TransactionStorage", "EntryFee");
            await MaxTransactionSizeTypedStorage.InitializeAsync("TransactionStorage", "MaxTransactionSize");
            await MaxBlockTransactionsTypedStorage.InitializeAsync("TransactionStorage", "MaxBlockTransactions");
            await StoragePeriodTypedStorage.InitializeAsync("TransactionStorage", "StoragePeriod");
            await BlockTransactionsTypedStorage.InitializeAsync("TransactionStorage", "BlockTransactions");
            await ProofCheckedTypedStorage.InitializeAsync("TransactionStorage", "ProofChecked");
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.Transactions
        /// </summary>
        [StorageChange("TransactionStorage", "Transactions")]
        public void OnUpdateTransactions(string key, string data)
        {
            TransactionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Transactions
        ///  Collection of transaction metadata by block number.
        /// </summary>
        public BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo> GetTransactions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TransactionsTypedStorage.Dictionary.TryGetValue(key, out BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.ChunkCount
        /// </summary>
        [StorageChange("TransactionStorage", "ChunkCount")]
        public void OnUpdateChunkCount(string key, string data)
        {
            ChunkCountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ChunkCount
        ///  Count indexed chunks for each block.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetChunkCount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ChunkCountTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.ByteFee
        /// </summary>
        [StorageChange("TransactionStorage", "ByteFee")]
        public void OnUpdateByteFee(string data)
        {
            ByteFeeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ByteFee
        ///  Storage fee per byte.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetByteFee()
        {
            return ByteFeeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.EntryFee
        /// </summary>
        [StorageChange("TransactionStorage", "EntryFee")]
        public void OnUpdateEntryFee(string data)
        {
            EntryFeeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> EntryFee
        ///  Storage fee per transaction.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetEntryFee()
        {
            return EntryFeeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.MaxTransactionSize
        /// </summary>
        [StorageChange("TransactionStorage", "MaxTransactionSize")]
        public void OnUpdateMaxTransactionSize(string data)
        {
            MaxTransactionSizeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> MaxTransactionSize
        ///  Maximum data set in a single transaction in bytes.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetMaxTransactionSize()
        {
            return MaxTransactionSizeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.MaxBlockTransactions
        /// </summary>
        [StorageChange("TransactionStorage", "MaxBlockTransactions")]
        public void OnUpdateMaxBlockTransactions(string data)
        {
            MaxBlockTransactionsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> MaxBlockTransactions
        ///  Maximum number of indexed transactions in the block.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetMaxBlockTransactions()
        {
            return MaxBlockTransactionsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.StoragePeriod
        /// </summary>
        [StorageChange("TransactionStorage", "StoragePeriod")]
        public void OnUpdateStoragePeriod(string data)
        {
            StoragePeriodTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StoragePeriod
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetStoragePeriod()
        {
            return StoragePeriodTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.BlockTransactions
        /// </summary>
        [StorageChange("TransactionStorage", "BlockTransactions")]
        public void OnUpdateBlockTransactions(string data)
        {
            BlockTransactionsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> BlockTransactions
        /// </summary>
        public BaseVec<SubstrateNET.NetApi.Generated.Model.PalletTransactionStorage.TransactionInfo> GetBlockTransactions()
        {
            return BlockTransactionsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionStorage.ProofChecked
        /// </summary>
        [StorageChange("TransactionStorage", "ProofChecked")]
        public void OnUpdateProofChecked(string data)
        {
            ProofCheckedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProofChecked
        ///  Was the proof checked in this block?
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetProofChecked()
        {
            return ProofCheckedTypedStorage.Get();
        }
    }
}
