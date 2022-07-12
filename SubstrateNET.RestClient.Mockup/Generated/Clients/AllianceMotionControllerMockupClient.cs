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
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
   using SubstrateNET.NetApi.Generated.Model.PalletCollective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.SpCore;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AllianceMotionControllerMockupClient : MockupBaseClient, IAllianceMotionControllerMockupClient
   {
      private HttpClient _httpClient;
      public AllianceMotionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposals(BoundedVecT38 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Proposals", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.ProposalsParams());
      }
      public async Task<bool> SetProposalOf(EnumNodeCall value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/ProposalOf", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.ProposalOfParams(key));
      }
      public async Task<bool> SetVoting(Votes value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Voting", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.VotingParams(key));
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/ProposalCount", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.ProposalCountParams());
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Members", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.MembersParams());
      }
      public async Task<bool> SetPrime(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Prime", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletAllianceMotion.AllianceMotionStorage.PrimeParams());
      }
   }
}
