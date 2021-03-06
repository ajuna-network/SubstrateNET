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
   using SubstrateNET.NetApi.Generated.Model.PalletBounties;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class BountiesControllerClient : BaseClient, IBountiesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BountiesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetBountyCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "bounties/bountycount");
      }
      public async Task<bool> SubscribeBountyCount()
      {
         return await _subscriptionClient.SubscribeAsync("Bounties.BountyCount");
      }
      public async Task<Bounty> GetBounties(U32 key)
      {
         return await SendRequestAsync<Bounty>(_httpClient, "bounties/bounties", BountiesStorage.BountiesParams(key));
      }
      public async Task<bool> SubscribeBounties(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Bounties.Bounties", BountiesStorage.BountiesParams(key));
      }
      public async Task<BoundedVecT30> GetBountyDescriptions(U32 key)
      {
         return await SendRequestAsync<BoundedVecT30>(_httpClient, "bounties/bountydescriptions", BountiesStorage.BountyDescriptionsParams(key));
      }
      public async Task<bool> SubscribeBountyDescriptions(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Bounties.BountyDescriptions", BountiesStorage.BountyDescriptionsParams(key));
      }
      public async Task<BoundedVecT16> GetBountyApprovals()
      {
         return await SendRequestAsync<BoundedVecT16>(_httpClient, "bounties/bountyapprovals");
      }
      public async Task<bool> SubscribeBountyApprovals()
      {
         return await _subscriptionClient.SubscribeAsync("Bounties.BountyApprovals");
      }
   }
}
