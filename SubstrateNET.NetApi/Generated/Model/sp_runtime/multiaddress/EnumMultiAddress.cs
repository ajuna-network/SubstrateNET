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


namespace SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress
{
    
    
    public enum MultiAddress
    {
        
        Id = 0,
        
        Index = 1,
        
        Raw = 2,
        
        Address32 = 3,
        
        Address20 = 4,
    }
    
    /// <summary>
    /// >> 138 - Variant[sp_runtime.multiaddress.MultiAddress]
    /// </summary>
    public sealed class EnumMultiAddress : BaseEnumExt<MultiAddress, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>, SubstrateNET.NetApi.Generated.Types.Base.Arr32U8, SubstrateNET.NetApi.Generated.Types.Base.Arr20U8>
    {
    }
}
