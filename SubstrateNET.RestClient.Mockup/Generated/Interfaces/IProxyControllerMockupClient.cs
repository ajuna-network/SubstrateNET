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
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IProxyControllerMockupClient
   {
      Task<bool> SetProxies(BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT23, Ajuna.NetApi.Model.Types.Primitive.U128> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetAnnouncements(BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT24, Ajuna.NetApi.Model.Types.Primitive.U128> value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
   }
}
