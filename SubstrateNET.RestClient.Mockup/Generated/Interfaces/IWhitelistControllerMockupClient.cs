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
   
   public interface IWhitelistControllerMockupClient
   {
      Task<bool> SetWhitelistedCall(BaseTuple value, SubstrateNET.NetApi.Generated.Model.primitive_types.H256 key);
   }
}
