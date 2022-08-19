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
   
   public sealed class WhitelistControllerMockupClient : MockupBaseClient, IWhitelistControllerMockupClient
   {
      private HttpClient _httpClient;
      public WhitelistControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetWhitelistedCall(BaseTuple value, SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Whitelist/WhitelistedCall", value.Encode(), SubstrateNET.NetApi.Generated.Storage.WhitelistStorage.WhitelistedCallParams(key));
      }
   }
}
