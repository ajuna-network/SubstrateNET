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
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpArithmetic
{
    
    
    /// <summary>
    /// >> 183 - Composite[sp_arithmetic.per_things.PerU16]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PerU16 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U16 _value;
        
        public Ajuna.NetApi.Model.Types.Primitive.U16 Value
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
            return "PerU16";
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
            Value = new Ajuna.NetApi.Model.Types.Primitive.U16();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
