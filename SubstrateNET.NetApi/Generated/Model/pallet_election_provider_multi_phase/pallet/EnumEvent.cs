//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.pallet
{
    
    
    public enum Event
    {
        
        SolutionStored = 0,
        
        ElectionFinalized = 1,
        
        Rewarded = 2,
        
        Slashed = 3,
        
        SignedPhaseStarted = 4,
        
        UnsignedPhaseStarted = 5,
    }
    
    /// <summary>
    /// >> 36 - Variant[pallet_election_provider_multi_phase.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/v3/runtime/events-and-errors) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.EnumElectionCompute, Ajuna.NetApi.Model.Types.Primitive.Bool>, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.EnumElectionCompute>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>
    {
    }
}