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


namespace SubstrateNET.NetApi.Generated.Model.pallet_uniques.pallet
{
    
    
    public enum Error
    {
        
        NoPermission = 0,
        
        UnknownCollection = 1,
        
        AlreadyExists = 2,
        
        WrongOwner = 3,
        
        BadWitness = 4,
        
        InUse = 5,
        
        Frozen = 6,
        
        WrongDelegate = 7,
        
        NoDelegate = 8,
        
        Unapproved = 9,
        
        Unaccepted = 10,
        
        Locked = 11,
        
        MaxSupplyReached = 12,
        
        MaxSupplyAlreadySet = 13,
        
        MaxSupplyTooSmall = 14,
        
        UnknownItem = 15,
        
        NotForSale = 16,
        
        BidTooLow = 17,
    }
    
    /// <summary>
    /// >> 598 - Variant[pallet_uniques.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
