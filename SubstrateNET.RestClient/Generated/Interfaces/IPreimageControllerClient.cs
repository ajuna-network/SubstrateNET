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
   using SubstrateNET.NetApi.Generated.Model.pallet_preimage;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IPreimageControllerClient
   {
      Task<EnumRequestStatus> GetStatusFor(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeStatusFor(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
      Task<BoundedVecT32> GetPreimageFor(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32> key);
      Task<bool> SubscribePreimageFor(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32> key);
   }
}
