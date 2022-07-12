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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.PalletChildBounties;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public interface IChildBountiesControllerClient
   {
      Task<U32> GetChildBountyCount();
      Task<bool> SubscribeChildBountyCount();
      Task<U32> GetParentChildBounties(U32 key);
      Task<bool> SubscribeParentChildBounties(U32 key);
      Task<ChildBounty> GetChildBounties(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key);
      Task<bool> SubscribeChildBounties(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key);
      Task<BoundedVecT25> GetChildBountyDescriptions(U32 key);
      Task<bool> SubscribeChildBountyDescriptions(U32 key);
      Task<U128> GetChildrenCuratorFees(U32 key);
      Task<bool> SubscribeChildrenCuratorFees(U32 key);
   }
}
