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


namespace SubstrateNET.NetApi.Generated.Model.pallet_im_online.pallet
{
    
    
    public enum Error
    {
        
        InvalidKey = 0,
        
        DuplicatedHeartbeat = 1,
    }
    
    /// <summary>
    /// >> 502 - Variant[pallet_im_online.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/v3/runtime/events-and-errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
