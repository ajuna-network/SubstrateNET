//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletSociety
{
    
    
    public enum BidKind
    {
        
        Deposit,
        
        Vouch,
    }
    
    /// <summary>
    /// >> 498 - Variant[pallet_society.BidKind]
    /// </summary>
    public sealed class EnumBidKind : BaseEnumExt<BidKind, Ajuna.NetApi.Model.Types.Primitive.U128, BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
