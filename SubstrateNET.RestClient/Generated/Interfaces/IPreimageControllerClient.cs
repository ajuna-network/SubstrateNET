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
   using SubstrateNET.NetApi.Generated.Model.PalletPreimage;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public interface IPreimageControllerClient
   {
      Task<EnumRequestStatus> GetStatusFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SubscribeStatusFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<BoundedVecT18> GetPreimageFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SubscribePreimageFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
   }
}
