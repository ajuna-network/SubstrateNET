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


namespace SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.signed
{
    
    
    /// <summary>
    /// >> 420 - Composite[pallet_election_provider_multi_phase.signed.SignedSubmission]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class SignedSubmission : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> raw_solution
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.RawSolution _rawSolution;
        
        /// <summary>
        /// >> call_fee
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _callFee;
        
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
        
        public SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.RawSolution RawSolution
        {
            get
            {
                return this._rawSolution;
            }
            set
            {
                this._rawSolution = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 CallFee
        {
            get
            {
                return this._callFee;
            }
            set
            {
                this._callFee = value;
            }
        }
        
        public override string TypeName()
        {
            return "SignedSubmission";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(RawSolution.Encode());
            result.AddRange(CallFee.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            RawSolution = new SubstrateNET.NetApi.Generated.Model.pallet_election_provider_multi_phase.RawSolution();
            RawSolution.Decode(byteArray, ref p);
            CallFee = new Ajuna.NetApi.Model.Types.Primitive.U128();
            CallFee.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
