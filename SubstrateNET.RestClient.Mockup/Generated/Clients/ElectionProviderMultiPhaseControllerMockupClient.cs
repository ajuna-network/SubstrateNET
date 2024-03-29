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
   using SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.signed;
   using SubstrateNET.NetApi.Generated.Model.sp_npos_elections;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ElectionProviderMultiPhaseControllerMockupClient : MockupBaseClient, IElectionProviderMultiPhaseControllerMockupClient
   {
      private HttpClient _httpClient;
      public ElectionProviderMultiPhaseControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRound(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/Round", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.RoundParams());
      }
      public async Task<bool> SetCurrentPhase(EnumPhase value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/CurrentPhase", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.CurrentPhaseParams());
      }
      public async Task<bool> SetQueuedSolution(ReadySolution value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/QueuedSolution", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.QueuedSolutionParams());
      }
      public async Task<bool> SetSnapshot(RoundSnapshot value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/Snapshot", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.SnapshotParams());
      }
      public async Task<bool> SetDesiredTargets(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/DesiredTargets", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.DesiredTargetsParams());
      }
      public async Task<bool> SetSnapshotMetadata(SolutionOrSnapshotSize value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SnapshotMetadata", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.SnapshotMetadataParams());
      }
      public async Task<bool> SetSignedSubmissionNextIndex(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionNextIndex", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionNextIndexParams());
      }
      public async Task<bool> SetSignedSubmissionIndices(BoundedVecT13 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionIndices", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionIndicesParams());
      }
      public async Task<bool> SetSignedSubmissionsMap(SignedSubmission value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionsMap", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionsMapParams(key));
      }
      public async Task<bool> SetMinimumUntrustedScore(ElectionScore value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/MinimumUntrustedScore", value.Encode(), SubstrateNET.NetApi.Generated.Storage.ElectionProviderMultiPhaseStorage.MinimumUntrustedScoreParams());
      }
   }
}
