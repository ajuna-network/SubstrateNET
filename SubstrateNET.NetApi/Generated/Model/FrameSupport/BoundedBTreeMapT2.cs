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
using SubstrateNET.NetApi.Generated.Model.Base;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 605 - Composite[frame_support.storage.bounded_btree_map.BoundedBTreeMapT2]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedBTreeMapT2 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.Base.BTreeMapT3 _value;
        
        public SubstrateNET.NetApi.Generated.Model.Base.BTreeMapT3 Value
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
            return "BoundedBTreeMapT2";
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
            Value = new SubstrateNET.NetApi.Generated.Model.Base.BTreeMapT3();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
