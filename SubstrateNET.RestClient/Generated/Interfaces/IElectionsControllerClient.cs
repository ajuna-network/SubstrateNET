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
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.PalletElectionsPhragmen;
   
   public interface IElectionsControllerClient
   {
      Task<BaseVec<SeatHolder>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<BaseVec<SeatHolder>> GetRunnersUp();
      Task<bool> SubscribeRunnersUp();
      Task<BaseVec<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U128>>> GetCandidates();
      Task<bool> SubscribeCandidates();
      Task<U32> GetElectionRounds();
      Task<bool> SubscribeElectionRounds();
      Task<Voter> GetVoting(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribeVoting(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
   }
}
