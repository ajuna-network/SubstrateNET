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


namespace SubstrateNET.NetApi.Generated.Model.pallet_lottery.pallet
{
    
    
    public enum Error
    {
        
        NotConfigured = 0,
        
        InProgress = 1,
        
        AlreadyEnded = 2,
        
        InvalidCall = 3,
        
        AlreadyParticipating = 4,
        
        TooManyCalls = 5,
        
        EncodingFailed = 6,
    }
    
    /// <summary>
    /// >> 582 - Variant[pallet_lottery.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
