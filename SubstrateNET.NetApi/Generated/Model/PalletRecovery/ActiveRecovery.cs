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
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletRecovery
{
    
    
    /// <summary>
    /// >> 491 - Composite[pallet_recovery.ActiveRecovery]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ActiveRecovery : BaseType
    {
        
        /// <summary>
        /// >> created
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _created;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> friends
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT16 _friends;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Created
        {
            get
            {
                return this._created;
            }
            set
            {
                this._created = value;
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
        
        public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT16 Friends
        {
            get
            {
                return this._friends;
            }
            set
            {
                this._friends = value;
            }
        }
        
        public override string TypeName()
        {
            return "ActiveRecovery";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Created.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Friends.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Created = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Created.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Friends = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT16();
            Friends.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
