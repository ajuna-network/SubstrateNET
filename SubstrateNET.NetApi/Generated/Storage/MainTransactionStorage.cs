//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Storage
{
    
    
    public sealed class TransactionStorageStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TransactionStorageStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "Transactions"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "ChunkCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "ByteFee"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "EntryFee"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "StoragePeriod"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "BlockTransactions"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionStorage", "ProofChecked"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> TransactionsParams
        ///  Collection of transaction metadata by block number.
        /// </summary>
        public static string TransactionsParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("TransactionStorage", "Transactions", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Transactions
        ///  Collection of transaction metadata by block number.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39> Transactions(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TransactionStorageStorage.TransactionsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39>(parameters, token);
        }
        
        /// <summary>
        /// >> ChunkCountParams
        ///  Count indexed chunks for each block.
        /// </summary>
        public static string ChunkCountParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ChunkCount", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ChunkCount
        ///  Count indexed chunks for each block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> ChunkCount(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ChunkCountParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ByteFeeParams
        ///  Storage fee per byte.
        /// </summary>
        public static string ByteFeeParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ByteFee", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ByteFee
        ///  Storage fee per byte.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> ByteFee(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ByteFeeParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> EntryFeeParams
        ///  Storage fee per transaction.
        /// </summary>
        public static string EntryFeeParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "EntryFee", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EntryFee
        ///  Storage fee per transaction.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> EntryFee(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.EntryFeeParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> StoragePeriodParams
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        public static string StoragePeriodParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "StoragePeriod", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StoragePeriod
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> StoragePeriod(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.StoragePeriodParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> BlockTransactionsParams
        /// </summary>
        public static string BlockTransactionsParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "BlockTransactions", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockTransactions
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39> BlockTransactions(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.BlockTransactionsParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39>(parameters, token);
        }
        
        /// <summary>
        /// >> ProofCheckedParams
        ///  Was the proof checked in this block?
        /// </summary>
        public static string ProofCheckedParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ProofChecked", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ProofChecked
        ///  Was the proof checked in this block?
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.Bool> ProofChecked(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ProofCheckedParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
    }
    
    public sealed class TransactionStorageCalls
    {
        
        /// <summary>
        /// >> store
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Store(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(data.Encode());
            return new Method(41, "TransactionStorage", 0, "store", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> renew
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Renew(Ajuna.NetApi.Model.Types.Primitive.U32 block, Ajuna.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(block.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(41, "TransactionStorage", 1, "renew", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> check_proof
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CheckProof(SubstrateNET.NetApi.Generated.Model.sp_transaction_storage_proof.TransactionStorageProof proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            return new Method(41, "TransactionStorage", 2, "check_proof", byteArray.ToArray());
        }
    }
    
    public enum TransactionStorageErrors
    {
        
        /// <summary>
        /// >> InsufficientFunds
        /// Insufficient account balance.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> NotConfigured
        /// Invalid configuration.
        /// </summary>
        NotConfigured,
        
        /// <summary>
        /// >> RenewedNotFound
        /// Renewed extrinsic is not found.
        /// </summary>
        RenewedNotFound,
        
        /// <summary>
        /// >> EmptyTransaction
        /// Attempting to store empty transaction
        /// </summary>
        EmptyTransaction,
        
        /// <summary>
        /// >> UnexpectedProof
        /// Proof was not expected in this block.
        /// </summary>
        UnexpectedProof,
        
        /// <summary>
        /// >> InvalidProof
        /// Proof failed verification.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> MissingProof
        /// Missing storage proof.
        /// </summary>
        MissingProof,
        
        /// <summary>
        /// >> MissingStateData
        /// Unable to verify proof becasue state data is missing.
        /// </summary>
        MissingStateData,
        
        /// <summary>
        /// >> DoubleCheck
        /// Double proof check in the block.
        /// </summary>
        DoubleCheck,
        
        /// <summary>
        /// >> ProofNotChecked
        /// Storage proof was not checked in the block.
        /// </summary>
        ProofNotChecked,
        
        /// <summary>
        /// >> TransactionTooLarge
        /// Transaction is too large.
        /// </summary>
        TransactionTooLarge,
        
        /// <summary>
        /// >> TooManyTransactions
        /// Too many transactions in the block.
        /// </summary>
        TooManyTransactions,
        
        /// <summary>
        /// >> BadContext
        /// Attempted to call `store` outside of block execution.
        /// </summary>
        BadContext,
    }
}
