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


namespace SubstrateNET.NetApi.Generated.Model.pallet_alliance.pallet
{
    
    
    public enum Call
    {
        
        propose = 0,
        
        vote = 1,
        
        veto = 2,
        
        close = 3,
        
        init_members = 4,
        
        set_rule = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        join_alliance = 8,
        
        nominate_ally = 9,
        
        elevate_ally = 10,
        
        retire = 11,
        
        kick_member = 12,
        
        add_unscrupulous_items = 13,
        
        remove_unscrupulous_items = 14,
    }
    
    /// <summary>
    /// >> 366 - Variant[pallet_alliance.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.node_runtime.EnumCall, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.Bool>, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>>, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid, BaseVoid, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem>, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem>>
    {
    }
}
