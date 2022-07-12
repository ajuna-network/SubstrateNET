//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.PalletNominationPools;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public interface INominationPoolsControllerClient
   {
      Task<U128> GetMinJoinBond();
      Task<bool> SubscribeMinJoinBond();
      Task<U128> GetMinCreateBond();
      Task<bool> SubscribeMinCreateBond();
      Task<U32> GetMaxPools();
      Task<bool> SubscribeMaxPools();
      Task<U32> GetMaxPoolMembers();
      Task<bool> SubscribeMaxPoolMembers();
      Task<U32> GetMaxPoolMembersPerPool();
      Task<bool> SubscribeMaxPoolMembersPerPool();
      Task<PoolMember> GetPoolMembers(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribePoolMembers(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<U32> GetCounterForPoolMembers();
      Task<bool> SubscribeCounterForPoolMembers();
      Task<BondedPoolInner> GetBondedPools(U32 key);
      Task<bool> SubscribeBondedPools(U32 key);
      Task<U32> GetCounterForBondedPools();
      Task<bool> SubscribeCounterForBondedPools();
      Task<RewardPool> GetRewardPools(U32 key);
      Task<bool> SubscribeRewardPools(U32 key);
      Task<U32> GetCounterForRewardPools();
      Task<bool> SubscribeCounterForRewardPools();
      Task<SubPools> GetSubPoolsStorage(U32 key);
      Task<bool> SubscribeSubPoolsStorage(U32 key);
      Task<U32> GetCounterForSubPoolsStorage();
      Task<bool> SubscribeCounterForSubPoolsStorage();
      Task<BoundedVecT27> GetMetadata(U32 key);
      Task<bool> SubscribeMetadata(U32 key);
      Task<U32> GetCounterForMetadata();
      Task<bool> SubscribeCounterForMetadata();
      Task<U32> GetLastPoolId();
      Task<bool> SubscribeLastPoolId();
      Task<U32> GetReversePoolIdLookup(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribeReversePoolIdLookup(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<U32> GetCounterForReversePoolIdLookup();
      Task<bool> SubscribeCounterForReversePoolIdLookup();
   }
}
