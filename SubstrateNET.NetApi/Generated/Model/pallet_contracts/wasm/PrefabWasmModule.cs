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


namespace SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm
{
    
    
    /// <summary>
    /// >> 488 - Composite[pallet_contracts.wasm.PrefabWasmModule]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PrefabWasmModule : BaseType
    {
        
        /// <summary>
        /// >> instruction_weights_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _instructionWeightsVersion;
        
        /// <summary>
        /// >> initial
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _initial;
        
        /// <summary>
        /// >> maximum
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _maximum;
        
        /// <summary>
        /// >> code
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4 _code;
        
        /// <summary>
        /// >> determinism
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.EnumDeterminism _determinism;
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> InstructionWeightsVersion
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
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Initial
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
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Maximum
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
        
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4 Code
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
        
        public SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.EnumDeterminism Determinism
        {
            get
            {
                return this._determinism;
            }
            set
            {
                this._determinism = value;
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
            result.AddRange(Determinism.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InstructionWeightsVersion = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            InstructionWeightsVersion.Decode(byteArray, ref p);
            Initial = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Initial.Decode(byteArray, ref p);
            Maximum = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Maximum.Decode(byteArray, ref p);
            Code = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4();
            Code.Decode(byteArray, ref p);
            Determinism = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.EnumDeterminism();
            Determinism.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
