//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.pallet_lottery;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   
   public interface ILotteryControllerClient
   {
      Task<U32> GetLotteryIndex();
      Task<bool> SubscribeLotteryIndex();
      Task<LotteryConfig> GetLottery();
      Task<bool> SubscribeLottery();
      Task<BaseTuple<U32, BoundedVecT31>> GetParticipants(AccountId32 key);
      Task<bool> SubscribeParticipants(AccountId32 key);
      Task<U32> GetTicketsCount();
      Task<bool> SubscribeTicketsCount();
      Task<AccountId32> GetTickets(U32 key);
      Task<bool> SubscribeTickets(U32 key);
      Task<BoundedVecT31> GetCallIndices();
      Task<bool> SubscribeCallIndices();
   }
}
