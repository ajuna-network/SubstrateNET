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
   using SubstrateNET.NetApi.Generated.Model.pallet_child_bounties;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class ChildBountiesControllerClient : BaseClient, IChildBountiesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ChildBountiesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetChildBountyCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "childbounties/childbountycount");
      }
      public async Task<bool> SubscribeChildBountyCount()
      {
         return await _subscriptionClient.SubscribeAsync("ChildBounties.ChildBountyCount");
      }
      public async Task<U32> GetParentChildBounties(U32 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "childbounties/parentchildbounties", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ParentChildBountiesParams(key));
      }
      public async Task<bool> SubscribeParentChildBounties(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("ChildBounties.ParentChildBounties", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ParentChildBountiesParams(key));
      }
      public async Task<ChildBounty> GetChildBounties(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key)
      {
         return await SendRequestAsync<ChildBounty>(_httpClient, "childbounties/childbounties", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildBountiesParams(key));
      }
      public async Task<bool> SubscribeChildBounties(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("ChildBounties.ChildBounties", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildBountiesParams(key));
      }
      public async Task<BoundedVecT35> GetChildBountyDescriptions(U32 key)
      {
         return await SendRequestAsync<BoundedVecT35>(_httpClient, "childbounties/childbountydescriptions", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildBountyDescriptionsParams(key));
      }
      public async Task<bool> SubscribeChildBountyDescriptions(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("ChildBounties.ChildBountyDescriptions", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildBountyDescriptionsParams(key));
      }
      public async Task<U128> GetChildrenCuratorFees(U32 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "childbounties/childrencuratorfees", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildrenCuratorFeesParams(key));
      }
      public async Task<bool> SubscribeChildrenCuratorFees(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("ChildBounties.ChildrenCuratorFees", SubstrateNET.NetApi.Generated.Storage.ChildBountiesStorage.ChildrenCuratorFeesParams(key));
      }
   }
}
