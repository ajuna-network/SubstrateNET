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
   using SubstrateNET.NetApi.Generated.Model.sp_staking.offence;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IOffencesControllerMockupClient
   {
      Task<bool> SetReports(OffenceDetails value, H256 key);
      Task<bool> SetConcurrentReportsIndex(BaseVec<H256> value, BaseTuple<SubstrateNET.NetApi.Generated.Types.Base.Arr16U8, BaseVec<U8>> key);
      Task<bool> SetReportsByKindIndex(BaseVec<U8> value, SubstrateNET.NetApi.Generated.Types.Base.Arr16U8 key);
   }
}
