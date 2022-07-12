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
   using SubstrateNET.NetApi.Generated.Model.PalletTips;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class TipsControllerClient : BaseClient, ITipsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TipsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<OpenTip> GetTips(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendRequestAsync<OpenTip>(_httpClient, "tips/tips", TipsStorage.TipsParams(key));
      }
      public async Task<bool> SubscribeTips(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Tips.Tips", TipsStorage.TipsParams(key));
      }
      public async Task<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> GetReasons(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendRequestAsync<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>(_httpClient, "tips/reasons", TipsStorage.ReasonsParams(key));
      }
      public async Task<bool> SubscribeReasons(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Tips.Reasons", TipsStorage.ReasonsParams(key));
      }
   }
}
