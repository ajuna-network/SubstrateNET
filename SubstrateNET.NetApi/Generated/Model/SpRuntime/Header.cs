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
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpRuntime
{
    
    
    /// <summary>
    /// >> 142 - Composite[sp_runtime.generic.header.Header]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Header : BaseType
    {
        
        /// <summary>
        /// >> parent_hash
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 _parentHash;
        
        /// <summary>
        /// >> number
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _number;
        
        /// <summary>
        /// >> state_root
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 _stateRoot;
        
        /// <summary>
        /// >> extrinsics_root
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 _extrinsicsRoot;
        
        /// <summary>
        /// >> digest
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.Digest _digest;
        
        public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 ParentHash
        {
            get
            {
                return this._parentHash;
            }
            set
            {
                this._parentHash = value;
            }
        }
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 StateRoot
        {
            get
            {
                return this._stateRoot;
            }
            set
            {
                this._stateRoot = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 ExtrinsicsRoot
        {
            get
            {
                return this._extrinsicsRoot;
            }
            set
            {
                this._extrinsicsRoot = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.Digest Digest
        {
            get
            {
                return this._digest;
            }
            set
            {
                this._digest = value;
            }
        }
        
        public override string TypeName()
        {
            return "Header";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ParentHash.Encode());
            result.AddRange(Number.Encode());
            result.AddRange(StateRoot.Encode());
            result.AddRange(ExtrinsicsRoot.Encode());
            result.AddRange(Digest.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ParentHash = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
            ParentHash.Decode(byteArray, ref p);
            Number = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Number.Decode(byteArray, ref p);
            StateRoot = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
            StateRoot.Decode(byteArray, ref p);
            ExtrinsicsRoot = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
            ExtrinsicsRoot.Decode(byteArray, ref p);
            Digest = new SubstrateNET.NetApi.Generated.Model.SpRuntime.Digest();
            Digest.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
