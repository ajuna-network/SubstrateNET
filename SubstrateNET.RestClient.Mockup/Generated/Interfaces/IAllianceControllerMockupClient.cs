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
   using SubstrateNET.NetApi.Generated.Model.pallet_alliance.types;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IAllianceControllerMockupClient
   {
      Task<bool> SetRule(Cid value);
      Task<bool> SetAnnouncements(BoundedVecT44 value);
      Task<bool> SetDepositOf(U128 value, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetMembers(BoundedVecT45 value, SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumMemberRole key);
      Task<bool> SetRetiringMembers(U32 value, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetUnscrupulousAccounts(BoundedVecT17 value);
      Task<bool> SetUnscrupulousWebsites(BoundedVecT46 value);
   }
}
