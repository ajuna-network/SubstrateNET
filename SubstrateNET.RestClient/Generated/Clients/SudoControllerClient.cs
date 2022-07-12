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
   using SubstrateNET.NetApi.Generated.Model.SpCore;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class SudoControllerClient : BaseClient, ISudoControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SudoControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountId32> GetKey()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "sudo/key");
      }
      public async Task<bool> SubscribeKey()
      {
         return await _subscriptionClient.SubscribeAsync("Sudo.Key");
      }
   }
}
