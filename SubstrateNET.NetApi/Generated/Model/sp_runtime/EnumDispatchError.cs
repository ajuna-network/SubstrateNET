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


namespace SubstrateNET.NetApi.Generated.Model.sp_runtime
{
    
    
    public enum DispatchError
    {
        
        Other = 0,
        
        CannotLookup = 1,
        
        BadOrigin = 2,
        
        Module = 3,
        
        ConsumerRemaining = 4,
        
        NoProviders = 5,
        
        TooManyConsumers = 6,
        
        Token = 7,
        
        Arithmetic = 8,
        
        Transactional = 9,
        
        Exhausted = 10,
        
        Corruption = 11,
        
        Unavailable = 12,
    }
    
    /// <summary>
    /// >> 24 - Variant[sp_runtime.DispatchError]
    /// </summary>
    public sealed class EnumDispatchError : BaseEnumExt<DispatchError, BaseVoid, BaseVoid, BaseVoid, SubstrateNET.NetApi.Generated.Model.sp_runtime.ModuleError, BaseVoid, BaseVoid, BaseVoid, SubstrateNET.NetApi.Generated.Model.sp_runtime.EnumTokenError, SubstrateNET.NetApi.Generated.Model.sp_runtime.EnumArithmeticError, SubstrateNET.NetApi.Generated.Model.sp_runtime.EnumTransactionalError, BaseVoid, BaseVoid, BaseVoid>
    {
    }
}
