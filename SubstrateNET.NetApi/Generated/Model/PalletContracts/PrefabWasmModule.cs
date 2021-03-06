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
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 480 - Composite[pallet_contracts.wasm.PrefabWasmModule]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PrefabWasmModule : BaseType
    {
        
        /// <summary>
        /// >> instruction_weights_version
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _instructionWeightsVersion;
        
        /// <summary>
        /// >> initial
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _initial;
        
        /// <summary>
        /// >> maximum
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _maximum;
        
        /// <summary>
        /// >> code
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT18 _code;
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> InstructionWeightsVersion
        {
            get
            {
                return this._instructionWeightsVersion;
            }
            set
            {
                this._instructionWeightsVersion = value;
            }
        }
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Initial
        {
            get
            {
                return this._initial;
            }
            set
            {
                this._initial = value;
            }
        }
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT18 Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        public override string TypeName()
        {
            return "PrefabWasmModule";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(InstructionWeightsVersion.Encode());
            result.AddRange(Initial.Encode());
            result.AddRange(Maximum.Encode());
            result.AddRange(Code.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InstructionWeightsVersion = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            InstructionWeightsVersion.Decode(byteArray, ref p);
            Initial = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Initial.Decode(byteArray, ref p);
            Maximum = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Maximum.Decode(byteArray, ref p);
            Code = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT18();
            Code.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
