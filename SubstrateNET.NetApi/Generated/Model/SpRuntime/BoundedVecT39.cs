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
using SubstrateNET.NetApi.Generated.Model.PalletAlliance;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpRuntime
{
    
    
    /// <summary>
    /// >> 630 - Composite[sp_runtime.bounded.bounded_vec.BoundedVecT39]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedVecT39 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<SubstrateNET.NetApi.Generated.Model.PalletAlliance.Cid> _value;
        
        public BaseVec<SubstrateNET.NetApi.Generated.Model.PalletAlliance.Cid> Value
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
            return "BoundedVecT39";
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
            Value = new BaseVec<SubstrateNET.NetApi.Generated.Model.PalletAlliance.Cid>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}