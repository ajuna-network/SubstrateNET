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
using SubstrateNET.NetApi.Generated.Model.FrameSupport;
using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting
{
    
    
    /// <summary>
    /// >> 584 - Composite[pallet_conviction_voting.vote.Casting]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Casting : BaseType
    {
        
        /// <summary>
        /// >> votes
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT26 _votes;
        
        /// <summary>
        /// >> delegations
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Delegations _delegations;
        
        /// <summary>
        /// >> prior
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.PriorLock _prior;
        
        public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT26 Votes
        {
            get
            {
                return this._votes;
            }
            set
            {
                this._votes = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Delegations Delegations
        {
            get
            {
                return this._delegations;
            }
            set
            {
                this._delegations = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.PriorLock Prior
        {
            get
            {
                return this._prior;
            }
            set
            {
                this._prior = value;
            }
        }
        
        public override string TypeName()
        {
            return "Casting";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Votes.Encode());
            result.AddRange(Delegations.Encode());
            result.AddRange(Prior.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Votes = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT26();
            Votes.Decode(byteArray, ref p);
            Delegations = new SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Delegations();
            Delegations.Decode(byteArray, ref p);
            Prior = new SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.PriorLock();
            Prior.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
