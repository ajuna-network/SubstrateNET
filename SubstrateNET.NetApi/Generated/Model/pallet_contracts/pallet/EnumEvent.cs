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


namespace SubstrateNET.NetApi.Generated.Model.pallet_contracts.pallet
{
    
    
    public enum Event
    {
        
        Instantiated = 0,
        
        Terminated = 1,
        
        CodeStored = 2,
        
        ContractEmitted = 3,
        
        CodeRemoved = 4,
        
        ContractCodeUpdated = 5,
    }
    
    /// <summary>
    /// >> 62 - Variant[pallet_contracts.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/v3/runtime/events-and-errors) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, SubstrateNET.NetApi.Generated.Model.primitive_types.H256, SubstrateNET.NetApi.Generated.Model.primitive_types.H256>>
    {
    }
}
