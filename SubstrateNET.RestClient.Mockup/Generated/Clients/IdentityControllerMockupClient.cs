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
   using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class IdentityControllerMockupClient : MockupBaseClient, IIdentityControllerMockupClient
   {
      private HttpClient _httpClient;
      public IdentityControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetIdentityOf(Registration value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/IdentityOf", value.Encode(), IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SetSuperOf(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, EnumData> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SuperOf", value.Encode(), IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SetSubsOf(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, BoundedVecT23> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SubsOf", value.Encode(), IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SetRegistrars(BoundedVecT24 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/Registrars", value.Encode(), IdentityStorage.RegistrarsParams());
      }
   }
}
