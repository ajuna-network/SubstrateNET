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


namespace SubstrateNET.NetApi.Generated.Model.PalletReferenda
{
    
    
    /// <summary>
    /// >> 608 - Composite[pallet_referenda.types.DecidingStatus]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class DecidingStatus : BaseType
    {
        
        /// <summary>
        /// >> since
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _since;
        
        /// <summary>
        /// >> confirming
        /// </summary>
        private BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _confirming;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Since
        {
            get
            {
                return this._since;
            }
            set
            {
                this._since = value;
            }
        }
        
        public BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> Confirming
        {
            get
            {
                return this._confirming;
            }
            set
            {
                this._confirming = value;
            }
        }
        
        public override string TypeName()
        {
            return "DecidingStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Since.Encode());
            result.AddRange(Confirming.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Since = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Since.Decode(byteArray, ref p);
            Confirming = new BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Confirming.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
