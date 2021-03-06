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
using SubstrateNET.NetApi.Generated.Model.PalletContracts;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 488 - Composite[pallet_contracts.schedule.Schedule]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Schedule : BaseType
    {
        
        /// <summary>
        /// >> limits
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletContracts.Limits _limits;
        
        /// <summary>
        /// >> instruction_weights
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletContracts.InstructionWeights _instructionWeights;
        
        /// <summary>
        /// >> host_fn_weights
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletContracts.HostFnWeights _hostFnWeights;
        
        public SubstrateNET.NetApi.Generated.Model.PalletContracts.Limits Limits
        {
            get
            {
                return this._limits;
            }
            set
            {
                this._limits = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletContracts.InstructionWeights InstructionWeights
        {
            get
            {
                return this._instructionWeights;
            }
            set
            {
                this._instructionWeights = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletContracts.HostFnWeights HostFnWeights
        {
            get
            {
                return this._hostFnWeights;
            }
            set
            {
                this._hostFnWeights = value;
            }
        }
        
        public override string TypeName()
        {
            return "Schedule";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Limits.Encode());
            result.AddRange(InstructionWeights.Encode());
            result.AddRange(HostFnWeights.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Limits = new SubstrateNET.NetApi.Generated.Model.PalletContracts.Limits();
            Limits.Decode(byteArray, ref p);
            InstructionWeights = new SubstrateNET.NetApi.Generated.Model.PalletContracts.InstructionWeights();
            InstructionWeights.Decode(byteArray, ref p);
            HostFnWeights = new SubstrateNET.NetApi.Generated.Model.PalletContracts.HostFnWeights();
            HostFnWeights.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
