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
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.pallet_society;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ISocietyControllerClient
   {
      Task<AccountId32> GetFounder();
      Task<bool> SubscribeFounder();
      Task<H256> GetRules();
      Task<bool> SubscribeRules();
      Task<BaseVec<Bid>> GetCandidates();
      Task<bool> SubscribeCandidates();
      Task<BaseTuple<U128, EnumBidKind>> GetSuspendedCandidates(AccountId32 key);
      Task<bool> SubscribeSuspendedCandidates(AccountId32 key);
      Task<U128> GetPot();
      Task<bool> SubscribePot();
      Task<AccountId32> GetHead();
      Task<bool> SubscribeHead();
      Task<BaseVec<AccountId32>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<Bool> GetSuspendedMembers(AccountId32 key);
      Task<bool> SubscribeSuspendedMembers(AccountId32 key);
      Task<BaseVec<Bid>> GetBids();
      Task<bool> SubscribeBids();
      Task<EnumVouchingStatus> GetVouching(AccountId32 key);
      Task<bool> SubscribeVouching(AccountId32 key);
      Task<BaseVec<BaseTuple<U32, U128>>> GetPayouts(AccountId32 key);
      Task<bool> SubscribePayouts(AccountId32 key);
      Task<U32> GetStrikes(AccountId32 key);
      Task<bool> SubscribeStrikes(AccountId32 key);
      Task<EnumVote> GetVotes(BaseTuple<AccountId32, AccountId32> key);
      Task<bool> SubscribeVotes(BaseTuple<AccountId32, AccountId32> key);
      Task<AccountId32> GetDefender();
      Task<bool> SubscribeDefender();
      Task<EnumVote> GetDefenderVotes(AccountId32 key);
      Task<bool> SubscribeDefenderVotes(AccountId32 key);
      Task<U32> GetMaxMembers();
      Task<bool> SubscribeMaxMembers();
   }
}
