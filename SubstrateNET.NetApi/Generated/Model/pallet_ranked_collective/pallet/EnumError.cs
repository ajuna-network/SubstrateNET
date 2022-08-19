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
    
    
    public enum Error
    {
        
        AlreadyMember = 0,
        
        NotMember = 1,
        
        NotPolling = 2,
        
        Ongoing = 3,
        
        NoneRemaining = 4,
        
        Corruption = 5,
        
        RankTooLow = 6,
        
        InvalidWitness = 7,
        
        NoPermission = 8,
    }
    
    /// <summary>
    /// >> 663 - Variant[pallet_ranked_collective.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/v3/runtime/events-and-errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
