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
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletElectionProviderMultiPhase
{
    
    
    public enum Phase
    {
        
        Off,
        
        Signed,
        
        Unsigned,
        
        Emergency,
    }
    
    /// <summary>
    /// >> 404 - Variant[pallet_election_provider_multi_phase.Phase]
    /// </summary>
    public sealed class EnumPhase : BaseEnumExt<Phase, BaseVoid, BaseVoid, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.Bool,Ajuna.NetApi.Model.Types.Primitive.U32>, BaseVoid>
    {
    }
}
