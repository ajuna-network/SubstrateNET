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
   using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   
   public interface IConvictionVotingControllerMockupClient
   {
      Task<bool> SetVotingFor(EnumVoting value, Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16> key);
      Task<bool> SetClassLocksFor(BoundedVecT37 value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
   }
}
