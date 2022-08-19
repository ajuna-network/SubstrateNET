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
   using SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools;
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class NominationPoolsControllerMockupClient : MockupBaseClient, INominationPoolsControllerMockupClient
   {
      private HttpClient _httpClient;
      public NominationPoolsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMinJoinBond(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/MinJoinBond", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MinJoinBondParams());
      }
      public async Task<bool> SetMinCreateBond(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/MinCreateBond", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MinCreateBondParams());
      }
      public async Task<bool> SetMaxPools(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/MaxPools", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MaxPoolsParams());
      }
      public async Task<bool> SetMaxPoolMembers(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/MaxPoolMembers", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MaxPoolMembersParams());
      }
      public async Task<bool> SetMaxPoolMembersPerPool(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/MaxPoolMembersPerPool", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MaxPoolMembersPerPoolParams());
      }
      public async Task<bool> SetPoolMembers(PoolMember value, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/PoolMembers", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.PoolMembersParams(key));
      }
      public async Task<bool> SetCounterForPoolMembers(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForPoolMembers", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForPoolMembersParams());
      }
      public async Task<bool> SetBondedPools(BondedPoolInner value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/BondedPools", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.BondedPoolsParams(key));
      }
      public async Task<bool> SetCounterForBondedPools(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForBondedPools", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForBondedPoolsParams());
      }
      public async Task<bool> SetRewardPools(RewardPool value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/RewardPools", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.RewardPoolsParams(key));
      }
      public async Task<bool> SetCounterForRewardPools(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForRewardPools", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForRewardPoolsParams());
      }
      public async Task<bool> SetSubPoolsStorage(SubPools value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/SubPoolsStorage", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.SubPoolsStorageParams(key));
      }
      public async Task<bool> SetCounterForSubPoolsStorage(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForSubPoolsStorage", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForSubPoolsStorageParams());
      }
      public async Task<bool> SetMetadata(BoundedVecT43 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/Metadata", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.MetadataParams(key));
      }
      public async Task<bool> SetCounterForMetadata(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForMetadata", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForMetadataParams());
      }
      public async Task<bool> SetLastPoolId(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/LastPoolId", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.LastPoolIdParams());
      }
      public async Task<bool> SetReversePoolIdLookup(U32 value, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/ReversePoolIdLookup", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.ReversePoolIdLookupParams(key));
      }
      public async Task<bool> SetCounterForReversePoolIdLookup(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "NominationPools/CounterForReversePoolIdLookup", value.Encode(), SubstrateNET.NetApi.Generated.Storage.NominationPoolsStorage.CounterForReversePoolIdLookupParams());
      }
   }
}
