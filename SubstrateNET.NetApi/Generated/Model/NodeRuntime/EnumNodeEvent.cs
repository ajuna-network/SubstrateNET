//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.NodeRuntime
{
    
    
    public enum NodeEvent
    {
        
        System,
        
        Utility,
        
        Indices,
        
        Balances,
        
        ElectionProviderMultiPhase,
        
        Staking,
        
        Session,
        
        Democracy,
        
        Council,
        
        TechnicalCommittee,
        
        Elections,
        
        TechnicalMembership,
        
        Grandpa,
        
        Treasury,
        
        Contracts,
        
        Sudo,
        
        ImOnline,
        
        Offences,
        
        Identity,
        
        Society,
        
        Recovery,
        
        Vesting,
        
        Scheduler,
        
        Preimage,
        
        Proxy,
        
        Multisig,
        
        Bounties,
        
        Tips,
        
        Assets,
        
        Lottery,
        
        Gilt,
        
        Uniques,
        
        TransactionStorage,
        
        BagsList,
        
        StateTrieMigration,
        
        ChildBounties,
        
        Referenda,
        
        ConvictionVoting,
        
        Whitelist,
    }
    
    /// <summary>
    /// >> 17 - Variant[node_runtime.Event]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Variant)]
    public sealed class EnumNodeEvent : BaseEnum<NodeEvent>
    {
    }
}
