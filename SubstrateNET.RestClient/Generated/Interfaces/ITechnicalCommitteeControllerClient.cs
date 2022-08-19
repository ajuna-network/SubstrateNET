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
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.node_runtime;
   using SubstrateNET.NetApi.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   
   public interface ITechnicalCommitteeControllerClient
   {
      Task<BoundedVecT14> GetProposals();
      Task<bool> SubscribeProposals();
      Task<EnumCall> GetProposalOf(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeProposalOf(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<Votes> GetVoting(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeVoting(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<U32> GetProposalCount();
      Task<bool> SubscribeProposalCount();
      Task<BaseVec<AccountId32>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<AccountId32> GetPrime();
      Task<bool> SubscribePrime();
   }
}
