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
   using SubstrateNET.NetApi.Generated.Model.pallet_multisig;
   
   public interface IMultisigControllerClient
   {
      Task<Multisig> GetMultisigs(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Types.Base.Arr32U8> key);
      Task<bool> SubscribeMultisigs(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Types.Base.Arr32U8> key);
   }
}
