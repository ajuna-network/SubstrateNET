//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ITransactionStorageControllerMockupClient
   {
      Task<bool> SetTransactions(BoundedVecT34 value, U32 key);
      Task<bool> SetChunkCount(U32 value, U32 key);
      Task<bool> SetByteFee(U128 value);
      Task<bool> SetEntryFee(U128 value);
      Task<bool> SetStoragePeriod(U32 value);
      Task<bool> SetBlockTransactions(BoundedVecT34 value);
      Task<bool> SetProofChecked(Bool value);
   }
}
