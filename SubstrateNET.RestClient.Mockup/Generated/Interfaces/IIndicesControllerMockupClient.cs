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
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IIndicesControllerMockupClient
   {
      Task<bool> SetAccounts(BaseTuple<AccountId32, U128, Bool> value, U32 key);
   }
}
