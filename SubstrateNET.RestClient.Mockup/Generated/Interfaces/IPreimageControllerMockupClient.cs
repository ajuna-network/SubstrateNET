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
   using SubstrateNET.NetApi.Generated.Model.PalletPreimage;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public interface IPreimageControllerMockupClient
   {
      Task<bool> SetStatusFor(EnumRequestStatus value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SetPreimageFor(BoundedVecT22 value, SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
   }
}
