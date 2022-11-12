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


namespace SubstrateNET.NetApi.Generated.Model.pallet_democracy.pallet
{
    
    
    public enum Event
    {
        
        Proposed = 0,
        
        Tabled = 1,
        
        ExternalTabled = 2,
        
        Started = 3,
        
        Passed = 4,
        
        NotPassed = 5,
        
        Cancelled = 6,
        
        Delegated = 7,
        
        Undelegated = 8,
        
        Vetoed = 9,
        
        Blacklisted = 10,
        
        Voted = 11,
        
        Seconded = 12,
        
        ProposalCanceled = 13,
    }
    
    /// <summary>
    /// >> 47 - Variant[pallet_democracy.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_democracy.vote.EnumAccountVote>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.U32>
    {
    }
}
