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


namespace SubstrateNET.NetApi.Generated.Model.pallet_gilt.pallet
{
    
    
    /// <summary>
    /// >> 588 - Composite[pallet_gilt.pallet.ActiveGilt]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ActiveGilt : BaseType
    {
        
        /// <summary>
        /// >> proportion
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perquintill _proportion;
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> who
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        /// <summary>
        /// >> expiry
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _expiry;
        
        public SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perquintill Proportion
        {
            get
            {
                return this._proportion;
            }
            set
            {
                this._proportion = value;
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
        
        public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 Who
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
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Expiry
        {
            get
            {
                return this._expiry;
            }
            set
            {
                this._expiry = value;
            }
        }
        
        public override string TypeName()
        {
            return "ActiveGilt";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Proportion.Encode());
            result.AddRange(Amount.Encode());
            result.AddRange(Who.Encode());
            result.AddRange(Expiry.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Proportion = new SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perquintill();
            Proportion.Decode(byteArray, ref p);
            Amount = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Who = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Expiry = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Expiry.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
