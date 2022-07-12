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
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class WhitelistControllerClient : BaseClient, IWhitelistControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public WhitelistControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple> GetWhitelistedCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendRequestAsync<BaseTuple>(_httpClient, "whitelist/whitelistedcall", SubstrateNET.NetApi.Generated.Model.PalletWhitelist.WhitelistStorage.WhitelistedCallParams(key));
      }
      public async Task<bool> SubscribeWhitelistedCall(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Whitelist.WhitelistedCall", SubstrateNET.NetApi.Generated.Model.PalletWhitelist.WhitelistStorage.WhitelistedCallParams(key));
      }
   }
}
