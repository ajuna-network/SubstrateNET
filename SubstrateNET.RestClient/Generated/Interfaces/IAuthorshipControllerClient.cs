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
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IAuthorshipControllerClient
   {
      Task<BoundedVecT9> GetUncles();
      Task<bool> SubscribeUncles();
      Task<AccountId32> GetAuthor();
      Task<bool> SubscribeAuthor();
      Task<Bool> GetDidSetUncles();
      Task<bool> SubscribeDidSetUncles();
   }
}
