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
   using SubstrateNET.NetApi.Generated.Model.PalletUniques;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IUniquesControllerClient
   {
      Task<ClassDetails> GetClass(U32 key);
      Task<bool> SubscribeClass(U32 key);
      Task<U32> GetOwnershipAcceptance(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribeOwnershipAcceptance(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<BaseTuple> GetAccount(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32, U32> key);
      Task<bool> SubscribeAccount(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32, U32> key);
      Task<BaseTuple> GetClassAccount(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32> key);
      Task<bool> SubscribeClassAccount(BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, U32> key);
      Task<InstanceDetails> GetAsset(BaseTuple<U32, U32> key);
      Task<bool> SubscribeAsset(BaseTuple<U32, U32> key);
      Task<ClassMetadata> GetClassMetadataOf(U32 key);
      Task<bool> SubscribeClassMetadataOf(U32 key);
      Task<InstanceMetadata> GetInstanceMetadataOf(BaseTuple<U32, U32> key);
      Task<bool> SubscribeInstanceMetadataOf(BaseTuple<U32, U32> key);
      Task<BaseTuple<SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT3, U128>> GetAttribute(BaseTuple<U32, BaseOpt<U32>, SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT2> key);
      Task<bool> SubscribeAttribute(BaseTuple<U32, BaseOpt<U32>, SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT2> key);
   }
}
