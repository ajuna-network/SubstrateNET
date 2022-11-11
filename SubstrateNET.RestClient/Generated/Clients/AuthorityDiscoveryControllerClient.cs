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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class AuthorityDiscoveryControllerClient : BaseClient, IAuthorityDiscoveryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AuthorityDiscoveryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<WeakBoundedVecT8> GetKeys()
      {
         return await SendRequestAsync<WeakBoundedVecT8>(_httpClient, "authoritydiscovery/keys");
      }
      public async Task<bool> SubscribeKeys()
      {
         return await _subscriptionClient.SubscribeAsync("AuthorityDiscovery.Keys");
      }
      public async Task<WeakBoundedVecT8> GetNextKeys()
      {
         return await SendRequestAsync<WeakBoundedVecT8>(_httpClient, "authoritydiscovery/nextkeys");
      }
      public async Task<bool> SubscribeNextKeys()
      {
         return await _subscriptionClient.SubscribeAsync("AuthorityDiscovery.NextKeys");
      }
   }
}
