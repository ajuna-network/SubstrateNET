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


namespace SubstrateNET.NetApi.Generated.Model.pallet_collective
{
    
    
    public enum RawOrigin
    {
        
        Members = 0,
        
        Member = 1,
        
        _Phantom = 2,
    }
    
    /// <summary>
    /// >> 121 - Variant[pallet_collective.RawOrigin]
    /// </summary>
    public sealed class EnumRawOrigin : BaseEnumExt<RawOrigin, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseVoid>
    {
    }
}
