//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.pallet_lottery;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class LotteryControllerClient : BaseClient, ILotteryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public LotteryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetLotteryIndex()
      {
         return await SendRequestAsync<U32>(_httpClient, "lottery/lotteryindex");
      }
      public async Task<bool> SubscribeLotteryIndex()
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.LotteryIndex");
      }
      public async Task<LotteryConfig> GetLottery()
      {
         return await SendRequestAsync<LotteryConfig>(_httpClient, "lottery/lottery");
      }
      public async Task<bool> SubscribeLottery()
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.Lottery");
      }
      public async Task<BaseTuple<U32, BoundedVecT36>> GetParticipants(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<U32, BoundedVecT36>>(_httpClient, "lottery/participants", SubstrateNET.NetApi.Generated.Storage.LotteryStorage.ParticipantsParams(key));
      }
      public async Task<bool> SubscribeParticipants(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.Participants", SubstrateNET.NetApi.Generated.Storage.LotteryStorage.ParticipantsParams(key));
      }
      public async Task<U32> GetTicketsCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "lottery/ticketscount");
      }
      public async Task<bool> SubscribeTicketsCount()
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.TicketsCount");
      }
      public async Task<AccountId32> GetTickets(U32 key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "lottery/tickets", SubstrateNET.NetApi.Generated.Storage.LotteryStorage.TicketsParams(key));
      }
      public async Task<bool> SubscribeTickets(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.Tickets", SubstrateNET.NetApi.Generated.Storage.LotteryStorage.TicketsParams(key));
      }
      public async Task<BoundedVecT36> GetCallIndices()
      {
         return await SendRequestAsync<BoundedVecT36>(_httpClient, "lottery/callindices");
      }
      public async Task<bool> SubscribeCallIndices()
      {
         return await _subscriptionClient.SubscribeAsync("Lottery.CallIndices");
      }
   }
}
