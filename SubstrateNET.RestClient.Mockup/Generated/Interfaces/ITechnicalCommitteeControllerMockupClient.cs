//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
   using SubstrateNET.NetApi.Generated.Model.PalletCollective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.SpCore;
   
   public interface ITechnicalCommitteeControllerMockupClient
   {
      Task<bool> SetProposals(BoundedVecT10 value);
      Task<bool> SetProposalOf(EnumNodeCall value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SetVoting(Votes value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SetProposalCount(U32 value);
      Task<bool> SetMembers(BaseVec<AccountId32> value);
      Task<bool> SetPrime(AccountId32 value);
   }
}
