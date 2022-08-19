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
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.node_runtime;
   using SubstrateNET.NetApi.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class AllianceMotionControllerClient : BaseClient, IAllianceMotionControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AllianceMotionControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT38> GetProposals()
      {
         return await SendRequestAsync<BoundedVecT38>(_httpClient, "alliancemotion/proposals");
      }
      public async Task<bool> SubscribeProposals()
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.Proposals");
      }
      public async Task<EnumCall> GetProposalOf(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumCall>(_httpClient, "alliancemotion/proposalof", SubstrateNET.NetApi.Generated.Storage.AllianceMotionStorage.ProposalOfParams(key));
      }
      public async Task<bool> SubscribeProposalOf(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.ProposalOf", SubstrateNET.NetApi.Generated.Storage.AllianceMotionStorage.ProposalOfParams(key));
      }
      public async Task<Votes> GetVoting(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<Votes>(_httpClient, "alliancemotion/voting", SubstrateNET.NetApi.Generated.Storage.AllianceMotionStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.Voting", SubstrateNET.NetApi.Generated.Storage.AllianceMotionStorage.VotingParams(key));
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "alliancemotion/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.ProposalCount");
      }
      public async Task<BaseVec<AccountId32>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "alliancemotion/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "alliancemotion/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("AllianceMotion.Prime");
      }
   }
}
