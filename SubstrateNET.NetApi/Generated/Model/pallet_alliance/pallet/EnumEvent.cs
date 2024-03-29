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


namespace SubstrateNET.NetApi.Generated.Model.pallet_alliance.pallet
{
    
    
    public enum Event
    {
        
        NewRuleSet = 0,
        
        Announced = 1,
        
        AnnouncementRemoved = 2,
        
        MembersInitialized = 3,
        
        NewAllyJoined = 4,
        
        AllyElevated = 5,
        
        MemberRetirementPeriodStarted = 6,
        
        MemberRetired = 7,
        
        MemberKicked = 8,
        
        UnscrupulousItemAdded = 9,
        
        UnscrupulousItemRemoved = 10,
        
        AllianceDisbanded = 11,
    }
    
    /// <summary>
    /// >> 357 - Variant[pallet_alliance.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U128>>, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U128>>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U128>>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
