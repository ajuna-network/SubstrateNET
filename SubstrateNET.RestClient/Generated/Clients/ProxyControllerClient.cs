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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class ProxyControllerClient : BaseClient, IProxyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ProxyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<BoundedVecT33, U128>> GetProxies(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT33, U128>>(_httpClient, "proxy/proxies", SubstrateNET.NetApi.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<bool> SubscribeProxies(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Proxies", SubstrateNET.NetApi.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<BaseTuple<BoundedVecT34, U128>> GetAnnouncements(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT34, U128>>(_httpClient, "proxy/announcements", SubstrateNET.NetApi.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
      public async Task<bool> SubscribeAnnouncements(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Announcements", SubstrateNET.NetApi.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
   }
}
