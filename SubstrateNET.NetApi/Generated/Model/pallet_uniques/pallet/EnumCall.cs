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


namespace SubstrateNET.NetApi.Generated.Model.pallet_uniques.pallet
{
    
    
    public enum Call
    {
        
        create = 0,
        
        force_create = 1,
        
        destroy = 2,
        
        mint = 3,
        
        burn = 4,
        
        transfer = 5,
        
        redeposit = 6,
        
        freeze = 7,
        
        thaw = 8,
        
        freeze_collection = 9,
        
        thaw_collection = 10,
        
        transfer_ownership = 11,
        
        set_team = 12,
        
        approve_transfer = 13,
        
        cancel_approval = 14,
        
        force_item_status = 15,
        
        set_attribute = 16,
        
        clear_attribute = 17,
        
        set_metadata = 18,
        
        clear_metadata = 19,
        
        set_collection_metadata = 20,
        
        clear_collection_metadata = 21,
        
        set_accept_ownership = 22,
        
        set_collection_max_supply = 23,
        
        set_price = 24,
        
        buy_item = 25,
    }
    
    /// <summary>
    /// >> 305 - Variant[pallet_uniques.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.pallet_uniques.types.DestroyWitness>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Ajuna.NetApi.Model.Types.Primitive.Bool, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT3>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT2>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT1, Ajuna.NetApi.Model.Types.Primitive.Bool>, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
