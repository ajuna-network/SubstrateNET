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
   using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class IdentityControllerClient : BaseClient, IIdentityControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IdentityControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Registration> GetIdentityOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<Registration>(_httpClient, "identity/identityof", IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SubscribeIdentityOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.IdentityOf", IdentityStorage.IdentityOfParams(key));
      }
      public async Task<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, EnumData>> GetSuperOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, EnumData>>(_httpClient, "identity/superof", IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SubscribeSuperOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SuperOf", IdentityStorage.SuperOfParams(key));
      }
      public async Task<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, BoundedVecT18>> GetSubsOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, BoundedVecT18>>(_httpClient, "identity/subsof", IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SubscribeSubsOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SubsOf", IdentityStorage.SubsOfParams(key));
      }
      public async Task<BoundedVecT19> GetRegistrars()
      {
         return await SendRequestAsync<BoundedVecT19>(_httpClient, "identity/registrars");
      }
      public async Task<bool> SubscribeRegistrars()
      {
         return await _subscriptionClient.SubscribeAsync("Identity.Registrars");
      }
   }
}
