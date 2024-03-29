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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.pallet_vesting;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class VestingControllerClient : BaseClient, IVestingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public VestingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT30> GetVesting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT30>(_httpClient, "vesting/vesting", SubstrateNET.NetApi.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<bool> SubscribeVesting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.Vesting", SubstrateNET.NetApi.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "vesting/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.StorageVersion");
      }
   }
}
