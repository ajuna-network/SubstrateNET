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
   
   public sealed class ProxyControllerClient : BaseClient, IProxyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ProxyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28, Ajuna.NetApi.Model.Types.Primitive.U128>> GetProxies(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28, Ajuna.NetApi.Model.Types.Primitive.U128>>(_httpClient, "proxy/proxies", SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.ProxiesParams(key));
      }
      public async Task<bool> SubscribeProxies(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Proxies", SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.ProxiesParams(key));
      }
      public async Task<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29, Ajuna.NetApi.Model.Types.Primitive.U128>> GetAnnouncements(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29, Ajuna.NetApi.Model.Types.Primitive.U128>>(_httpClient, "proxy/announcements", SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.AnnouncementsParams(key));
      }
      public async Task<bool> SubscribeAnnouncements(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Announcements", SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.AnnouncementsParams(key));
      }
   }
}
