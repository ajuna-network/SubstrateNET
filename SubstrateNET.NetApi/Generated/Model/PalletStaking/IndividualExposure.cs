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


namespace SubstrateNET.NetApi.Generated.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 70 - Composite[pallet_staking.IndividualExposure]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class IndividualExposure : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 _who;
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _value;
        
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
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Value
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
            return "IndividualExposure";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Value = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
