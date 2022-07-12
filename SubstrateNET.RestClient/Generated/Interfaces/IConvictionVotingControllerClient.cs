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
   using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IConvictionVotingControllerClient
   {
      Task<EnumVoting> GetVotingFor(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U8> key);
      Task<bool> SubscribeVotingFor(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U8> key);
      Task<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U128>>> GetClassLocksFor(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribeClassLocksFor(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
   }
}
