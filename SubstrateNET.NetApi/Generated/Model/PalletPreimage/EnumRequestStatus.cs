//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletPreimage
{
    
    
    public enum RequestStatus
    {
        
        Unrequested,
        
        Requested,
    }
    
    /// <summary>
    /// >> 510 - Variant[pallet_preimage.RequestStatus]
    /// </summary>
    public sealed class EnumRequestStatus : BaseEnumExt<RequestStatus, BaseOpt<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U128>>, Ajuna.NetApi.Model.Types.Primitive.U32>
    {
    }
}
