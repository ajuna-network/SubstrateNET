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


namespace SubstrateNET.NetApi.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Call
    {
        
        proxy = 0,
        
        add_proxy = 1,
        
        remove_proxy = 2,
        
        remove_proxies = 3,
        
        anonymous = 4,
        
        kill_anonymous = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        reject_announcement = 8,
        
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 324 - Variant[pallet_proxy.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType>, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumCall>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.node_runtime.EnumProxyType>, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumCall>>
    {
    }
}
