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
using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletIdentity
{
    
    
    /// <summary>
    /// >> 507 - Composite[pallet_identity.types.Registration]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Registration : BaseType
    {
        
        /// <summary>
        /// >> judgements
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT22 _judgements;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> info
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityInfo _info;
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT22 Judgements
        {
            get
            {
                return this._judgements;
            }
            set
            {
                this._judgements = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityInfo Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
        
        public override string TypeName()
        {
            return "Registration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Judgements.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Info.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Judgements = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT22();
            Judgements.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Info = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.IdentityInfo();
            Info.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
