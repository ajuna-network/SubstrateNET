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
   using SubstrateNET.NetApi.Generated.Model.sp_staking.offence;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class OffencesControllerClient : BaseClient, IOffencesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public OffencesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<OffenceDetails> GetReports(H256 key)
      {
         return await SendRequestAsync<OffenceDetails>(_httpClient, "offences/reports", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsParams(key));
      }
      public async Task<bool> SubscribeReports(H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Offences.Reports", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsParams(key));
      }
      public async Task<BaseVec<H256>> GetConcurrentReportsIndex(BaseTuple<SubstrateNET.NetApi.Generated.Types.Base.Arr16U8, BaseVec<U8>> key)
      {
         return await SendRequestAsync<BaseVec<H256>>(_httpClient, "offences/concurrentreportsindex", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ConcurrentReportsIndexParams(key));
      }
      public async Task<bool> SubscribeConcurrentReportsIndex(BaseTuple<SubstrateNET.NetApi.Generated.Types.Base.Arr16U8, BaseVec<U8>> key)
      {
         return await _subscriptionClient.SubscribeAsync("Offences.ConcurrentReportsIndex", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ConcurrentReportsIndexParams(key));
      }
      public async Task<BaseVec<U8>> GetReportsByKindIndex(SubstrateNET.NetApi.Generated.Types.Base.Arr16U8 key)
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "offences/reportsbykindindex", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsByKindIndexParams(key));
      }
      public async Task<bool> SubscribeReportsByKindIndex(SubstrateNET.NetApi.Generated.Types.Base.Arr16U8 key)
      {
         return await _subscriptionClient.SubscribeAsync("Offences.ReportsByKindIndex", SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsByKindIndexParams(key));
      }
   }
}
