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


namespace SubstrateNET.NetApi.Generated.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 579 - Composite[frame_support.storage.bounded_vec.BoundedVecT25]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedVecT25 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U128>> _value;
        
        public BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U128>> Value
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
            return "BoundedVecT25";
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
            Value = new BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U128>>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
