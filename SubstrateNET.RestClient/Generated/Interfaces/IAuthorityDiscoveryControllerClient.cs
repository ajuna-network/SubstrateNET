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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec;
   
   public interface IAuthorityDiscoveryControllerClient
   {
      Task<WeakBoundedVecT8> GetKeys();
      Task<bool> SubscribeKeys();
      Task<WeakBoundedVecT8> GetNextKeys();
      Task<bool> SubscribeNextKeys();
   }
}
