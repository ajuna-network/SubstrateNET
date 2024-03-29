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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.pallet_vesting;
   
   public interface IVestingControllerClient
   {
      Task<BoundedVecT30> GetVesting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeVesting(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
   }
}
