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


namespace SubstrateNET.NetApi.Generated.Model.pallet_session.pallet
{
    
    
    public enum Call
    {
        
        set_keys = 0,
        
        purge_keys = 1,
    }
    
    /// <summary>
    /// >> 241 - Variant[pallet_session.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<SubstrateNET.NetApi.Generated.Model.node_runtime.SessionKeys, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>, BaseVoid>
    {
    }
}