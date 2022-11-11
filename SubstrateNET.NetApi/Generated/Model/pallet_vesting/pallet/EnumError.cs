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


namespace SubstrateNET.NetApi.Generated.Model.pallet_vesting.pallet
{
    
    
    public enum Error
    {
        
        NotVesting = 0,
        
        AtMaxVestingSchedules = 1,
        
        AmountLow = 2,
        
        ScheduleIndexOutOfBounds = 3,
        
        InvalidScheduleParams = 4,
    }
    
    /// <summary>
    /// >> 542 - Variant[pallet_vesting.pallet.Error]
    /// Error for the vesting pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
