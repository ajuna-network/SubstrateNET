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


namespace SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote
{
    
    
    /// <summary>
    /// >> 636 - Composite[pallet_conviction_voting.vote.Delegating]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Delegating : BaseType
    {
        
        /// <summary>
        /// >> balance
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _balance;
        
        /// <summary>
        /// >> target
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 _target;
        
        /// <summary>
        /// >> conviction
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.conviction.EnumConviction _conviction;
        
        /// <summary>
        /// >> delegations
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.types.Delegations _delegations;
        
        /// <summary>
        /// >> prior
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.PriorLock _prior;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.conviction.EnumConviction Conviction
        {
            get
            {
                return this._conviction;
            }
            set
            {
                this._conviction = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.types.Delegations Delegations
        {
            get
            {
                return this._delegations;
            }
            set
            {
                this._delegations = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.PriorLock Prior
        {
            get
            {
                return this._prior;
            }
            set
            {
                this._prior = value;
            }
        }
        
        public override string TypeName()
        {
            return "Delegating";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Balance.Encode());
            result.AddRange(Target.Encode());
            result.AddRange(Conviction.Encode());
            result.AddRange(Delegations.Encode());
            result.AddRange(Prior.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Balance = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            Target = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Target.Decode(byteArray, ref p);
            Conviction = new SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.conviction.EnumConviction();
            Conviction.Decode(byteArray, ref p);
            Delegations = new SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.types.Delegations();
            Delegations.Decode(byteArray, ref p);
            Prior = new SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.PriorLock();
            Prior.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
