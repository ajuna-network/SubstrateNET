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


namespace SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    public enum Event
    {
        
        MemberAdded = 0,
        
        RankChanged = 1,
        
        MemberRemoved = 2,
        
        Voted = 3,
    }
    
    /// <summary>
    /// >> 361 - Variant[pallet_ranked_collective.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.EnumVoteRecord, SubstrateNET.NetApi.Generated.Model.pallet_ranked_collective.Tally>>
    {
    }
}
