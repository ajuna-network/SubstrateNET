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
   using SubstrateNET.NetApi.Generated.Model.PalletBounties;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BountiesControllerMockupClient : MockupBaseClient, IBountiesControllerMockupClient
   {
      private HttpClient _httpClient;
      public BountiesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetBountyCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Bounties/BountyCount", value.Encode(), BountiesStorage.BountyCountParams());
      }
      public async Task<bool> SetBounties(Bounty value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Bounties/Bounties", value.Encode(), BountiesStorage.BountiesParams(key));
      }
      public async Task<bool> SetBountyDescriptions(BoundedVecT30 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Bounties/BountyDescriptions", value.Encode(), BountiesStorage.BountyDescriptionsParams(key));
      }
      public async Task<bool> SetBountyApprovals(BoundedVecT16 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Bounties/BountyApprovals", value.Encode(), BountiesStorage.BountyApprovalsParams());
      }
   }
}
