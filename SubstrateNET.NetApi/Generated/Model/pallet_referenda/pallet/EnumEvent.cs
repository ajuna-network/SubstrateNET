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


namespace SubstrateNET.NetApi.Generated.Model.pallet_referenda.pallet
{
    
    
    public enum Event
    {
        
        Submitted = 0,
        
        DecisionDepositPlaced = 1,
        
        DecisionDepositRefunded = 2,
        
        DepositSlashed = 3,
        
        DecisionStarted = 4,
        
        ConfirmStarted = 5,
        
        ConfirmAborted = 6,
        
        Confirmed = 7,
        
        Approved = 8,
        
        Rejected = 9,
        
        TimedOut = 10,
        
        Cancelled = 11,
        
        Killed = 12,
    }
    
    /// <summary>
    /// >> 127 - Variant[pallet_referenda.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/v3/runtime/events-and-errors) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U16, SubstrateNET.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U16, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>>
    {
    }
}