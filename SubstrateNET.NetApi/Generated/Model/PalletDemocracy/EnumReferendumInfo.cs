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
using SubstrateNET.NetApi.Generated.Model.PalletDemocracy;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletDemocracy
{
    
    
    public enum ReferendumInfo
    {
        
        Ongoing,
        
        Finished,
    }
    
    /// <summary>
    /// >> 421 - Variant[pallet_democracy.types.ReferendumInfo]
    /// </summary>
    public sealed class EnumReferendumInfo : BaseEnumExt<ReferendumInfo, SubstrateNET.NetApi.Generated.Model.PalletDemocracy.ReferendumStatus, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.Bool, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
