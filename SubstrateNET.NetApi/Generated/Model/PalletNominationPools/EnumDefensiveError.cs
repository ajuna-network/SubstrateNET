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


namespace SubstrateNET.NetApi.Generated.Model.PalletNominationPools
{
    
    
    public enum DefensiveError
    {
        
        NotEnoughSpaceInUnbondPool,
        
        PoolNotFound,
        
        RewardPoolNotFound,
        
        SubPoolsNotFound,
        
        BondedStashKilledPrematurely,
    }
    
    /// <summary>
    /// >> 654 - Variant[pallet_nomination_pools.pallet.DefensiveError]
    /// </summary>
    public sealed class EnumDefensiveError : BaseEnum<DefensiveError>
    {
    }
}
