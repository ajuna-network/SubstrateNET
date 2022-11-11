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


namespace SubstrateNET.NetApi.Generated.Model.sp_consensus_babe.digests
{
    
    
    /// <summary>
    /// >> 388 - Composite[sp_consensus_babe.digests.PrimaryPreDigest]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PrimaryPreDigest : BaseType
    {
        
        /// <summary>
        /// >> authority_index
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _authorityIndex;
        
        /// <summary>
        /// >> slot
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_consensus_slots.Slot _slot;
        
        /// <summary>
        /// >> vrf_output
        /// </summary>
        private SubstrateNET.NetApi.Generated.Types.Base.Arr32U8 _vrfOutput;
        
        /// <summary>
        /// >> vrf_proof
        /// </summary>
        private SubstrateNET.NetApi.Generated.Types.Base.Arr64U8 _vrfProof;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 AuthorityIndex
        {
            get
            {
                return this._authorityIndex;
            }
            set
            {
                this._authorityIndex = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.sp_consensus_slots.Slot Slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Types.Base.Arr32U8 VrfOutput
        {
            get
            {
                return this._vrfOutput;
            }
            set
            {
                this._vrfOutput = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Types.Base.Arr64U8 VrfProof
        {
            get
            {
                return this._vrfProof;
            }
            set
            {
                this._vrfProof = value;
            }
        }
        
        public override string TypeName()
        {
            return "PrimaryPreDigest";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AuthorityIndex.Encode());
            result.AddRange(Slot.Encode());
            result.AddRange(VrfOutput.Encode());
            result.AddRange(VrfProof.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AuthorityIndex = new Ajuna.NetApi.Model.Types.Primitive.U32();
            AuthorityIndex.Decode(byteArray, ref p);
            Slot = new SubstrateNET.NetApi.Generated.Model.sp_consensus_slots.Slot();
            Slot.Decode(byteArray, ref p);
            VrfOutput = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
            VrfOutput.Decode(byteArray, ref p);
            VrfProof = new SubstrateNET.NetApi.Generated.Types.Base.Arr64U8();
            VrfProof.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
