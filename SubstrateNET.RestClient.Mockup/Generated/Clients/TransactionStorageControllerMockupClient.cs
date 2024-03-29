//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TransactionStorageControllerMockupClient : MockupBaseClient, ITransactionStorageControllerMockupClient
   {
      private HttpClient _httpClient;
      public TransactionStorageControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetTransactions(BoundedVecT39 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/Transactions", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.TransactionsParams(key));
      }
      public async Task<bool> SetChunkCount(U32 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/ChunkCount", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.ChunkCountParams(key));
      }
      public async Task<bool> SetByteFee(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/ByteFee", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.ByteFeeParams());
      }
      public async Task<bool> SetEntryFee(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/EntryFee", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.EntryFeeParams());
      }
      public async Task<bool> SetStoragePeriod(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/StoragePeriod", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.StoragePeriodParams());
      }
      public async Task<bool> SetBlockTransactions(BoundedVecT39 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/BlockTransactions", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.BlockTransactionsParams());
      }
      public async Task<bool> SetProofChecked(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionStorage/ProofChecked", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TransactionStorageStorage.ProofCheckedParams());
      }
   }
}
