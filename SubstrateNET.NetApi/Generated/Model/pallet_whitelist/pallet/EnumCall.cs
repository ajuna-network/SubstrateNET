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


namespace SubstrateNET.NetApi.Generated.Model.pallet_whitelist.pallet
{
    
    
    public enum Call
    {
        
        whitelist_call = 0,
        
        remove_whitelisted_call = 1,
        
        dispatch_whitelisted_call = 2,
        
        dispatch_whitelisted_call_with_preimage = 3,
    }
    
    /// <summary>
    /// >> 327 - Variant[pallet_whitelist.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall>
    {
    }
}
