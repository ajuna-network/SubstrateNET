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


namespace SubstrateNET.NetApi.Generated.Model.pallet_identity.pallet
{
    
    
    public enum Call
    {
        
        add_registrar = 0,
        
        set_identity = 1,
        
        set_subs = 2,
        
        clear_identity = 3,
        
        request_judgement = 4,
        
        cancel_request = 5,
        
        set_fee = 6,
        
        set_account_id = 7,
        
        set_fields = 8,
        
        provide_judgement = 9,
        
        kill_identity = 10,
        
        add_sub = 11,
        
        rename_sub = 12,
        
        remove_sub = 13,
        
        quit_sub = 14,
    }
    
    /// <summary>
    /// >> 275 - Variant[pallet_identity.pallet.Call]
    /// Identity pallet declaration.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.IdentityInfo, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.EnumData>>, BaseVoid, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.BitFlags>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.EnumJudgement>, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.EnumData>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.pallet_identity.types.EnumData>, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid>
    {
    }
}
