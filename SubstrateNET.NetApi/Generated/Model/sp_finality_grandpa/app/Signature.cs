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


namespace SubstrateNET.NetApi.Generated.Model.sp_finality_grandpa.app
{
    
    
    /// <summary>
    /// >> 224 - Composite[sp_finality_grandpa.app.Signature]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Signature : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.ed25519.Signature _value;
        
        public SubstrateNET.NetApi.Generated.Model.sp_core.ed25519.Signature Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Signature";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new SubstrateNET.NetApi.Generated.Model.sp_core.ed25519.Signature();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
