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
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface ISchedulerControllerClient
   {
      Task<BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>>> GetAgenda(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeAgenda(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> GetLookup(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> key);
      Task<bool> SubscribeLookup(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> key);
   }
}
