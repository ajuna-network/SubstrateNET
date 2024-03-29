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
   using SubstrateNET.NetApi.Generated.Model.sp_staking.offence;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class OffencesControllerMockupClient : MockupBaseClient, IOffencesControllerMockupClient
   {
      private HttpClient _httpClient;
      public OffencesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetReports(OffenceDetails value, H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Offences/Reports", value.Encode(), SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsParams(key));
      }
      public async Task<bool> SetConcurrentReportsIndex(BaseVec<H256> value, BaseTuple<SubstrateNET.NetApi.Generated.Types.Base.Arr16U8, BaseVec<U8>> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Offences/ConcurrentReportsIndex", value.Encode(), SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ConcurrentReportsIndexParams(key));
      }
      public async Task<bool> SetReportsByKindIndex(BaseVec<U8> value, SubstrateNET.NetApi.Generated.Types.Base.Arr16U8 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Offences/ReportsByKindIndex", value.Encode(), SubstrateNET.NetApi.Generated.Storage.OffencesStorage.ReportsByKindIndexParams(key));
      }
   }
}
