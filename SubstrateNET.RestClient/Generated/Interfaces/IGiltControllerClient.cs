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
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.NetApi.Generated.Model.PalletGilt;
   
   public interface IGiltControllerClient
   {
      Task<BoundedVecT27> GetQueueTotals();
      Task<bool> SubscribeQueueTotals();
      Task<BoundedVecT28> GetQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<ActiveGiltsTotal> GetActiveTotal();
      Task<bool> SubscribeActiveTotal();
      Task<ActiveGilt> GetActive(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeActive(Ajuna.NetApi.Model.Types.Primitive.U32 key);
   }
}
