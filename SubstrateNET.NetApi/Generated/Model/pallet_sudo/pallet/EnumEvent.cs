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


namespace SubstrateNET.NetApi.Generated.Model.pallet_sudo.pallet
{
    
    
    public enum Event
    {
        
        Sudid = 0,
        
        KeyChanged = 1,
        
        SudoAsDone = 2,
    }
    
    /// <summary>
    /// >> 64 - Variant[pallet_sudo.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, SubstrateNET.NetApi.Generated.Types.Base.EnumResult, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, SubstrateNET.NetApi.Generated.Types.Base.EnumResult>
    {
    }
}
