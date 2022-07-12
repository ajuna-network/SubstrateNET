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
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ProxyControllerMockupClient : MockupBaseClient, IProxyControllerMockupClient
   {
      private HttpClient _httpClient;
      public ProxyControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProxies(BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT19, Ajuna.NetApi.Model.Types.Primitive.U128> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Proxy/Proxies", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.ProxiesParams(key));
      }
      public async Task<bool> SetAnnouncements(BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT20, Ajuna.NetApi.Model.Types.Primitive.U128> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Proxy/Announcements", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletProxy.ProxyStorage.AnnouncementsParams(key));
      }
   }
}
