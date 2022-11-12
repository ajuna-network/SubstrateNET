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


namespace SubstrateNET.NetApi.Generated.Model.pallet_collective.pallet
{
    
    
    public enum Call
    {
        
        set_members = 0,
        
        execute = 1,
        
        propose = 2,
        
        vote = 3,
        
        close_old_weight = 4,
        
        disapprove_proposal = 5,
        
        close = 6,
    }
    
    /// <summary>
    /// >> 328 - Variant[pallet_collective.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<SubstrateNET.NetApi.Generated.Model.sp_weights.OldWeight>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>>
    {
    }
}
