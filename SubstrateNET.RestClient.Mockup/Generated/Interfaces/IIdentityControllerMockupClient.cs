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
   using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public interface IIdentityControllerMockupClient
   {
      Task<bool> SetIdentityOf(Registration value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetSuperOf(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, EnumData> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetSubsOf(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, BoundedVecT14> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetRegistrars(BoundedVecT15 value);
   }
}
