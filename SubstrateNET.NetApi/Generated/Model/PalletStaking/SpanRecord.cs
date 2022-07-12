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


namespace SubstrateNET.NetApi.Generated.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 398 - Composite[pallet_staking.slashing.SpanRecord]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class SpanRecord : BaseType
    {
        
        /// <summary>
        /// >> slashed
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _slashed;
        
        /// <summary>
        /// >> paid_out
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _paidOut;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Slashed
        {
            get
            {
                return this._slashed;
            }
            set
            {
                this._slashed = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 PaidOut
        {
            get
            {
                return this._paidOut;
            }
            set
            {
                this._paidOut = value;
            }
        }
        
        public override string TypeName()
        {
            return "SpanRecord";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Slashed.Encode());
            result.AddRange(PaidOut.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Slashed = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Slashed.Decode(byteArray, ref p);
            PaidOut = new Ajuna.NetApi.Model.Types.Primitive.U128();
            PaidOut.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
