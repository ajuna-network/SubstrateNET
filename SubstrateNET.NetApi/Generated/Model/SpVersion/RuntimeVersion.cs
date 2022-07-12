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
using SubstrateNET.NetApi.Generated.Model.Base;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpVersion
{
    
    
    /// <summary>
    /// >> 131 - Composite[sp_version.RuntimeVersion]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class RuntimeVersion : BaseType
    {
        
        /// <summary>
        /// >> spec_name
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Str _specName;
        
        /// <summary>
        /// >> impl_name
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Str _implName;
        
        /// <summary>
        /// >> authoring_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _authoringVersion;
        
        /// <summary>
        /// >> spec_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _specVersion;
        
        /// <summary>
        /// >> impl_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _implVersion;
        
        /// <summary>
        /// >> apis
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.Base.Cow _apis;
        
        /// <summary>
        /// >> transaction_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _transactionVersion;
        
        /// <summary>
        /// >> state_version
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _stateVersion;
        
        public Ajuna.NetApi.Model.Types.Primitive.Str SpecName
        {
            get
            {
                return this._specName;
            }
            set
            {
                this._specName = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Str ImplName
        {
            get
            {
                return this._implName;
            }
            set
            {
                this._implName = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 AuthoringVersion
        {
            get
            {
                return this._authoringVersion;
            }
            set
            {
                this._authoringVersion = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 SpecVersion
        {
            get
            {
                return this._specVersion;
            }
            set
            {
                this._specVersion = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ImplVersion
        {
            get
            {
                return this._implVersion;
            }
            set
            {
                this._implVersion = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.Base.Cow Apis
        {
            get
            {
                return this._apis;
            }
            set
            {
                this._apis = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 TransactionVersion
        {
            get
            {
                return this._transactionVersion;
            }
            set
            {
                this._transactionVersion = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 StateVersion
        {
            get
            {
                return this._stateVersion;
            }
            set
            {
                this._stateVersion = value;
            }
        }
        
        public override string TypeName()
        {
            return "RuntimeVersion";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecName.Encode());
            result.AddRange(ImplName.Encode());
            result.AddRange(AuthoringVersion.Encode());
            result.AddRange(SpecVersion.Encode());
            result.AddRange(ImplVersion.Encode());
            result.AddRange(Apis.Encode());
            result.AddRange(TransactionVersion.Encode());
            result.AddRange(StateVersion.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecName = new Ajuna.NetApi.Model.Types.Primitive.Str();
            SpecName.Decode(byteArray, ref p);
            ImplName = new Ajuna.NetApi.Model.Types.Primitive.Str();
            ImplName.Decode(byteArray, ref p);
            AuthoringVersion = new Ajuna.NetApi.Model.Types.Primitive.U32();
            AuthoringVersion.Decode(byteArray, ref p);
            SpecVersion = new Ajuna.NetApi.Model.Types.Primitive.U32();
            SpecVersion.Decode(byteArray, ref p);
            ImplVersion = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ImplVersion.Decode(byteArray, ref p);
            Apis = new SubstrateNET.NetApi.Generated.Model.Base.Cow();
            Apis.Decode(byteArray, ref p);
            TransactionVersion = new Ajuna.NetApi.Model.Types.Primitive.U32();
            TransactionVersion.Decode(byteArray, ref p);
            StateVersion = new Ajuna.NetApi.Model.Types.Primitive.U8();
            StateVersion.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
