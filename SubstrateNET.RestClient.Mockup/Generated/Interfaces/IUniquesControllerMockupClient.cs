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
   using SubstrateNET.NetApi.Generated.Model.PalletUniques;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IUniquesControllerMockupClient
   {
      Task<bool> SetClass(ClassDetails value, U32 key);
      Task<bool> SetOwnershipAcceptance(U32 value, SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetAccount(BaseTuple value, BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32, U32> key);
      Task<bool> SetClassAccount(BaseTuple value, BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32> key);
      Task<bool> SetAsset(InstanceDetails value, BaseTuple<U32, U32> key);
      Task<bool> SetClassMetadataOf(ClassMetadata value, U32 key);
      Task<bool> SetInstanceMetadataOf(InstanceMetadata value, BaseTuple<U32, U32> key);
      Task<bool> SetAttribute(BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3, U128> value, BaseTuple<U32, BaseOpt<U32>, SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT2> key);
   }
}
