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
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IMmrControllerMockupClient
   {
      Task<bool> SetRootHash(H256 value);
      Task<bool> SetNumberOfLeaves(U64 value);
      Task<bool> SetNodes(H256 value, U64 key);
   }
}
