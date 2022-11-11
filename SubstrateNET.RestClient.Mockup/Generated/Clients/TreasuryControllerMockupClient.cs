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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.pallet_treasury;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TreasuryControllerMockupClient : MockupBaseClient, ITreasuryControllerMockupClient
   {
      private HttpClient _httpClient;
      public TreasuryControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/ProposalCount", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TreasuryStorage.ProposalCountParams());
      }
      public async Task<bool> SetProposals(Proposal value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Proposals", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TreasuryStorage.ProposalsParams(key));
      }
      public async Task<bool> SetApprovals(BoundedVecT22 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Approvals", value.Encode(), SubstrateNET.NetApi.Generated.Storage.TreasuryStorage.ApprovalsParams());
      }
   }
}
