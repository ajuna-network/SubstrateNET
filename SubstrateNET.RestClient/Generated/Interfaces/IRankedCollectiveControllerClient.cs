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
   using SubstrateNET.NetApi.Generated.Model.PalletRankedCollective;
   using SubstrateNET.NetApi.Generated.Model.SpCore;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   
   public interface IRankedCollectiveControllerClient
   {
      Task<U32> GetMemberCount(U16 key);
      Task<bool> SubscribeMemberCount(U16 key);
      Task<MemberRecord> GetMembers(AccountId32 key);
      Task<bool> SubscribeMembers(AccountId32 key);
      Task<U32> GetIdToIndex(Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, AccountId32> key);
      Task<bool> SubscribeIdToIndex(Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, AccountId32> key);
      Task<AccountId32> GetIndexToId(Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, U32> key);
      Task<bool> SubscribeIndexToId(Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, U32> key);
      Task<EnumVoteRecord> GetVoting(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeVoting(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, AccountId32> key);
      Task<BoundedVecT45> GetVotingCleanup(U32 key);
      Task<bool> SubscribeVotingCleanup(U32 key);
   }
}
