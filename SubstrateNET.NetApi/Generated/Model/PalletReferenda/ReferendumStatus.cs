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
using SubstrateNET.NetApi.Generated.Model.FrameSupport;
using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
using SubstrateNET.NetApi.Generated.Model.PalletReferenda;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletReferenda
{
    
    
    /// <summary>
    /// >> 563 - Composite[pallet_referenda.types.ReferendumStatus]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ReferendumStatus : BaseType
    {
        
        /// <summary>
        /// >> track
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _track;
        
        /// <summary>
        /// >> origin
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumOriginCaller _origin;
        
        /// <summary>
        /// >> proposal_hash
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 _proposalHash;
        
        /// <summary>
        /// >> enactment
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.FrameSupport.EnumDispatchTime _enactment;
        
        /// <summary>
        /// >> submitted
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _submitted;
        
        /// <summary>
        /// >> submission_deposit
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit _submissionDeposit;
        
        /// <summary>
        /// >> decision_deposit
        /// </summary>
        private BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit> _decisionDeposit;
        
        /// <summary>
        /// >> deciding
        /// </summary>
        private BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.DecidingStatus> _deciding;
        
        /// <summary>
        /// >> tally
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Tally _tally;
        
        /// <summary>
        /// >> in_queue
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _inQueue;
        
        /// <summary>
        /// >> alarm
        /// </summary>
        private BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>> _alarm;
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 Track
        {
            get
            {
                return this._track;
            }
            set
            {
                this._track = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumOriginCaller Origin
        {
            get
            {
                return this._origin;
            }
            set
            {
                this._origin = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 ProposalHash
        {
            get
            {
                return this._proposalHash;
            }
            set
            {
                this._proposalHash = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.FrameSupport.EnumDispatchTime Enactment
        {
            get
            {
                return this._enactment;
            }
            set
            {
                this._enactment = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Submitted
        {
            get
            {
                return this._submitted;
            }
            set
            {
                this._submitted = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit SubmissionDeposit
        {
            get
            {
                return this._submissionDeposit;
            }
            set
            {
                this._submissionDeposit = value;
            }
        }
        
        public BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit> DecisionDeposit
        {
            get
            {
                return this._decisionDeposit;
            }
            set
            {
                this._decisionDeposit = value;
            }
        }
        
        public BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.DecidingStatus> Deciding
        {
            get
            {
                return this._deciding;
            }
            set
            {
                this._deciding = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Tally Tally
        {
            get
            {
                return this._tally;
            }
            set
            {
                this._tally = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool InQueue
        {
            get
            {
                return this._inQueue;
            }
            set
            {
                this._inQueue = value;
            }
        }
        
        public BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>> Alarm
        {
            get
            {
                return this._alarm;
            }
            set
            {
                this._alarm = value;
            }
        }
        
        public override string TypeName()
        {
            return "ReferendumStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Track.Encode());
            result.AddRange(Origin.Encode());
            result.AddRange(ProposalHash.Encode());
            result.AddRange(Enactment.Encode());
            result.AddRange(Submitted.Encode());
            result.AddRange(SubmissionDeposit.Encode());
            result.AddRange(DecisionDeposit.Encode());
            result.AddRange(Deciding.Encode());
            result.AddRange(Tally.Encode());
            result.AddRange(InQueue.Encode());
            result.AddRange(Alarm.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Track = new Ajuna.NetApi.Model.Types.Primitive.U8();
            Track.Decode(byteArray, ref p);
            Origin = new SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumOriginCaller();
            Origin.Decode(byteArray, ref p);
            ProposalHash = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
            ProposalHash.Decode(byteArray, ref p);
            Enactment = new SubstrateNET.NetApi.Generated.Model.FrameSupport.EnumDispatchTime();
            Enactment.Decode(byteArray, ref p);
            Submitted = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Submitted.Decode(byteArray, ref p);
            SubmissionDeposit = new SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit();
            SubmissionDeposit.Decode(byteArray, ref p);
            DecisionDeposit = new BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.Deposit>();
            DecisionDeposit.Decode(byteArray, ref p);
            Deciding = new BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletReferenda.DecidingStatus>();
            Deciding.Decode(byteArray, ref p);
            Tally = new SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Tally();
            Tally.Decode(byteArray, ref p);
            InQueue = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            InQueue.Decode(byteArray, ref p);
            Alarm = new BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>>();
            Alarm.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
