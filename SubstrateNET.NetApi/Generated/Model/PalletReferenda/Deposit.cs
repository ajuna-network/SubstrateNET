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
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletReferenda
{
    
    
    /// <summary>
    /// >> 582 - Composite[pallet_referenda.types.Deposit]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Deposit : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 _who;
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _amount;
        
        public SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public override string TypeName()
        {
            return "Deposit";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Amount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Amount = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
