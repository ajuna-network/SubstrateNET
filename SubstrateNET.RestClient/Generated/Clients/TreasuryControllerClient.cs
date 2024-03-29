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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.pallet_treasury;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class TreasuryControllerClient : BaseClient, ITreasuryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TreasuryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "treasury/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("Treasury.ProposalCount");
      }
      public async Task<Proposal> GetProposals(U32 key)
      {
         return await SendRequestAsync<Proposal>(_httpClient, "treasury/proposals", SubstrateNET.NetApi.Generated.Storage.TreasuryStorage.ProposalsParams(key));
      }
      public async Task<bool> SubscribeProposals(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Treasury.Proposals", SubstrateNET.NetApi.Generated.Storage.TreasuryStorage.ProposalsParams(key));
      }
      public async Task<BoundedVecT22> GetApprovals()
      {
         return await SendRequestAsync<BoundedVecT22>(_httpClient, "treasury/approvals");
      }
      public async Task<bool> SubscribeApprovals()
      {
         return await _subscriptionClient.SubscribeAsync("Treasury.Approvals");
      }
   }
}
