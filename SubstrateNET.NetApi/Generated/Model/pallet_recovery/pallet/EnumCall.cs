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


namespace SubstrateNET.NetApi.Generated.Model.pallet_recovery.pallet
{
    
    
    public enum Call
    {
        
        as_recovered = 0,
        
        set_recovered = 1,
        
        create_recovery = 2,
        
        initiate_recovery = 3,
        
        vouch_recovery = 4,
        
        claim_recovery = 5,
        
        close_recovery = 6,
        
        remove_recovery = 7,
        
        cancel_recovered = 8,
    }
    
    /// <summary>
    /// >> 287 - Variant[pallet_recovery.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Primitive.U32>, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>
    {
    }
}
