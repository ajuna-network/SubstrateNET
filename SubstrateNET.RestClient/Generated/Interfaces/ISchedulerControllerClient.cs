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
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface ISchedulerControllerClient
   {
      Task<U32> GetIncompleteSince();
      Task<bool> SubscribeIncompleteSince();
      Task<BoundedVecT31> GetAgenda(U32 key);
      Task<bool> SubscribeAgenda(U32 key);
      Task<BaseTuple<U32, U32>> GetLookup(SubstrateNET.NetApi.Generated.Types.Base.Arr32U8 key);
      Task<bool> SubscribeLookup(SubstrateNET.NetApi.Generated.Types.Base.Arr32U8 key);
   }
}
