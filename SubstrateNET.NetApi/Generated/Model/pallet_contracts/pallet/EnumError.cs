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
    
    
    public enum Error
    {
        
        InvalidScheduleVersion = 0,
        
        InvalidCallFlags = 1,
        
        OutOfGas = 2,
        
        OutputBufferTooSmall = 3,
        
        TransferFailed = 4,
        
        MaxCallDepthReached = 5,
        
        ContractNotFound = 6,
        
        CodeTooLarge = 7,
        
        CodeNotFound = 8,
        
        OutOfBounds = 9,
        
        DecodingFailed = 10,
        
        ContractTrapped = 11,
        
        ValueTooLarge = 12,
        
        TerminatedWhileReentrant = 13,
        
        InputForwarded = 14,
        
        RandomSubjectTooLong = 15,
        
        TooManyTopics = 16,
        
        DuplicateTopics = 17,
        
        NoChainExtension = 18,
        
        DeletionQueueFull = 19,
        
        DuplicateContract = 20,
        
        TerminatedInConstructor = 21,
        
        DebugMessageInvalidUTF8 = 22,
        
        ReentranceDenied = 23,
        
        StorageDepositNotEnoughFunds = 24,
        
        StorageDepositLimitExhausted = 25,
        
        CodeInUse = 26,
        
        ContractReverted = 27,
        
        CodeRejected = 28,
        
        Indeterministic = 29,
    }
    
    /// <summary>
    /// >> 499 - Variant[pallet_contracts.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
