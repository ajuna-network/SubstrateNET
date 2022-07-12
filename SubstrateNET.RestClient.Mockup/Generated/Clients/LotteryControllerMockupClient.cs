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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.PalletLottery;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.SpCore;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class LotteryControllerMockupClient : MockupBaseClient, ILotteryControllerMockupClient
   {
      private HttpClient _httpClient;
      public LotteryControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetLotteryIndex(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/LotteryIndex", value.Encode(), LotteryStorage.LotteryIndexParams());
      }
      public async Task<bool> SetLottery(LotteryConfig value)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/Lottery", value.Encode(), LotteryStorage.LotteryParams());
      }
      public async Task<bool> SetParticipants(BaseTuple<U32, BoundedVecT26> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/Participants", value.Encode(), LotteryStorage.ParticipantsParams(key));
      }
      public async Task<bool> SetTicketsCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/TicketsCount", value.Encode(), LotteryStorage.TicketsCountParams());
      }
      public async Task<bool> SetTickets(AccountId32 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/Tickets", value.Encode(), LotteryStorage.TicketsParams(key));
      }
      public async Task<bool> SetCallIndices(BoundedVecT26 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Lottery/CallIndices", value.Encode(), LotteryStorage.CallIndicesParams());
      }
   }
}
