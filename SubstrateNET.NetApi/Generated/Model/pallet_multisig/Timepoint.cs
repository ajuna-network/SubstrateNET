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


namespace SubstrateNET.NetApi.Generated.Model.pallet_multisig
{
    
    
    /// <summary>
    /// >> 90 - Composite[pallet_multisig.Timepoint]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Timepoint : BaseType
    {
        
        /// <summary>
        /// >> height
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _height;
        
        /// <summary>
        /// >> index
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _index;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        
        public override string TypeName()
        {
            return "Timepoint";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Height.Encode());
            result.AddRange(Index.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Height = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Height.Decode(byteArray, ref p);
            Index = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Index.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
