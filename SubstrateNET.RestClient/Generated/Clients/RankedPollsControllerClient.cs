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
   using SubstrateNET.NetApi.Generated.Model.pallet_referenda.types;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class RankedPollsControllerClient : BaseClient, IRankedPollsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public RankedPollsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetReferendumCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "rankedpolls/referendumcount");
      }
      public async Task<bool> SubscribeReferendumCount()
      {
         return await _subscriptionClient.SubscribeAsync("RankedPolls.ReferendumCount");
      }
      public async Task<EnumReferendumInfo> GetReferendumInfoFor(U32 key)
      {
         return await SendRequestAsync<EnumReferendumInfo>(_httpClient, "rankedpolls/referenduminfofor", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.ReferendumInfoForParams(key));
      }
      public async Task<bool> SubscribeReferendumInfoFor(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("RankedPolls.ReferendumInfoFor", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.ReferendumInfoForParams(key));
      }
      public async Task<BoundedVecT48> GetTrackQueue(U16 key)
      {
         return await SendRequestAsync<BoundedVecT48>(_httpClient, "rankedpolls/trackqueue", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.TrackQueueParams(key));
      }
      public async Task<bool> SubscribeTrackQueue(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("RankedPolls.TrackQueue", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.TrackQueueParams(key));
      }
      public async Task<U32> GetDecidingCount(U16 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "rankedpolls/decidingcount", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.DecidingCountParams(key));
      }
      public async Task<bool> SubscribeDecidingCount(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("RankedPolls.DecidingCount", SubstrateNET.NetApi.Generated.Storage.RankedPollsStorage.DecidingCountParams(key));
      }
   }
}
