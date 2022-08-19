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


namespace SubstrateNET.NetApi.Generated.Model.pallet_tips.pallet
{
    
    
    public enum Error
    {
        
        ReasonTooBig = 0,
        
        AlreadyKnown = 1,
        
        UnknownTip = 2,
        
        NotFinder = 3,
        
        StillOpen = 4,
        
        Premature = 5,
    }
    
    /// <summary>
    /// >> 563 - Variant[pallet_tips.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/v3/runtime/events-and-errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
