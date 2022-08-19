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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.sp_consensus_slots;
   using SubstrateNET.NetApi.Generated.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_consensus_babe.digests;
   using SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_consensus_babe;
   
   public interface IBabeControllerMockupClient
   {
      Task<bool> SetEpochIndex(U64 value);
      Task<bool> SetAuthorities(WeakBoundedVecT1 value);
      Task<bool> SetGenesisSlot(Slot value);
      Task<bool> SetCurrentSlot(Slot value);
      Task<bool> SetRandomness(Arr32U8 value);
      Task<bool> SetPendingEpochConfigChange(EnumNextConfigDescriptor value);
      Task<bool> SetNextRandomness(Arr32U8 value);
      Task<bool> SetNextAuthorities(WeakBoundedVecT1 value);
      Task<bool> SetSegmentIndex(U32 value);
      Task<bool> SetUnderConstruction(BoundedVecT8 value, U32 key);
      Task<bool> SetInitialized(BaseOpt<EnumPreDigest> value);
      Task<bool> SetAuthorVrfRandomness(BaseOpt<Arr32U8> value);
      Task<bool> SetEpochStart(BaseTuple<U32, U32> value);
      Task<bool> SetLateness(U32 value);
      Task<bool> SetEpochConfig(BabeEpochConfiguration value);
      Task<bool> SetNextEpochConfig(BabeEpochConfiguration value);
   }
}
