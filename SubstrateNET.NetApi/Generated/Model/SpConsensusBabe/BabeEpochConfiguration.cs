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
using SubstrateNET.NetApi.Generated.Model.SpConsensusBabe;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpConsensusBabe
{
    
    
    /// <summary>
    /// >> 364 - Composite[sp_consensus_babe.BabeEpochConfiguration]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BabeEpochConfiguration : BaseType
    {
        
        /// <summary>
        /// >> c
        /// </summary>
        private BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64,Ajuna.NetApi.Model.Types.Primitive.U64> _c;
        
        /// <summary>
        /// >> allowed_slots
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.EnumAllowedSlots _allowedSlots;
        
        public BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64,Ajuna.NetApi.Model.Types.Primitive.U64> C
        {
            get
            {
                return this._c;
            }
            set
            {
                this._c = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.EnumAllowedSlots AllowedSlots
        {
            get
            {
                return this._allowedSlots;
            }
            set
            {
                this._allowedSlots = value;
            }
        }
        
        public override string TypeName()
        {
            return "BabeEpochConfiguration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(C.Encode());
            result.AddRange(AllowedSlots.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            C = new BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64,Ajuna.NetApi.Model.Types.Primitive.U64>();
            C.Decode(byteArray, ref p);
            AllowedSlots = new SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.EnumAllowedSlots();
            AllowedSlots.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
