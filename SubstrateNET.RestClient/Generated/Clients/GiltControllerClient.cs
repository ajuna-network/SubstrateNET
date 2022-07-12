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
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.NetApi.Generated.Model.PalletGilt;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class GiltControllerClient : BaseClient, IGiltControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public GiltControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT23> GetQueueTotals()
      {
         return await SendRequestAsync<BoundedVecT23>(_httpClient, "gilt/queuetotals");
      }
      public async Task<bool> SubscribeQueueTotals()
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.QueueTotals");
      }
      public async Task<BoundedVecT24> GetQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<BoundedVecT24>(_httpClient, "gilt/queues", GiltStorage.QueuesParams(key));
      }
      public async Task<bool> SubscribeQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.Queues", GiltStorage.QueuesParams(key));
      }
      public async Task<ActiveGiltsTotal> GetActiveTotal()
      {
         return await SendRequestAsync<ActiveGiltsTotal>(_httpClient, "gilt/activetotal");
      }
      public async Task<bool> SubscribeActiveTotal()
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.ActiveTotal");
      }
      public async Task<ActiveGilt> GetActive(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<ActiveGilt>(_httpClient, "gilt/active", GiltStorage.ActiveParams(key));
      }
      public async Task<bool> SubscribeActive(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.Active", GiltStorage.ActiveParams(key));
      }
   }
}
