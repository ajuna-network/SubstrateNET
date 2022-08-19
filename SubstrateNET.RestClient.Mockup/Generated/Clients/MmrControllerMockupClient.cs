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
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class MmrControllerMockupClient : MockupBaseClient, IMmrControllerMockupClient
   {
      private HttpClient _httpClient;
      public MmrControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRootHash(H256 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Mmr/RootHash", value.Encode(), SubstrateNET.NetApi.Generated.Storage.MmrStorage.RootHashParams());
      }
      public async Task<bool> SetNumberOfLeaves(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Mmr/NumberOfLeaves", value.Encode(), SubstrateNET.NetApi.Generated.Storage.MmrStorage.NumberOfLeavesParams());
      }
      public async Task<bool> SetNodes(H256 value, U64 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Mmr/Nodes", value.Encode(), SubstrateNET.NetApi.Generated.Storage.MmrStorage.NodesParams(key));
      }
   }
}
