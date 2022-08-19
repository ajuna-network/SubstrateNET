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
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.pallet_elections_phragmen;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class ElectionsControllerClient : BaseClient, IElectionsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ElectionsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<SeatHolder>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<SeatHolder>>(_httpClient, "elections/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("Elections.Members");
      }
      public async Task<BaseVec<SeatHolder>> GetRunnersUp()
      {
         return await SendRequestAsync<BaseVec<SeatHolder>>(_httpClient, "elections/runnersup");
      }
      public async Task<bool> SubscribeRunnersUp()
      {
         return await _subscriptionClient.SubscribeAsync("Elections.RunnersUp");
      }
      public async Task<BaseVec<BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, U128>>> GetCandidates()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, U128>>>(_httpClient, "elections/candidates");
      }
      public async Task<bool> SubscribeCandidates()
      {
         return await _subscriptionClient.SubscribeAsync("Elections.Candidates");
      }
      public async Task<U32> GetElectionRounds()
      {
         return await SendRequestAsync<U32>(_httpClient, "elections/electionrounds");
      }
      public async Task<bool> SubscribeElectionRounds()
      {
         return await _subscriptionClient.SubscribeAsync("Elections.ElectionRounds");
      }
      public async Task<Voter> GetVoting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<Voter>(_httpClient, "elections/voting", SubstrateNET.NetApi.Generated.Storage.ElectionsStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Elections.Voting", SubstrateNET.NetApi.Generated.Storage.ElectionsStorage.VotingParams(key));
      }
   }
}
