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


namespace SubstrateNET.NetApi.Generated.Model.pallet_whitelist.pallet
{
    
    
    public enum Event
    {
        
        CallWhitelisted = 0,
        
        WhitelistedCallRemoved = 1,
        
        WhitelistedCallDispatched = 2,
    }
    
    /// <summary>
    /// >> 351 - Variant[pallet_whitelist.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Types.Base.EnumResult>>
    {
    }
}
