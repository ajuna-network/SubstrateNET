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
    /// >> 635 - Composite[pallet_conviction_voting.vote.PriorLock]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PriorLock : BaseType
    {
        
        /// <summary>
        /// >> BlockNumber
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _blockNumber;
        
        /// <summary>
        /// >> Balance
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _balance;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 BlockNumber
        {
            get
            {
                return this._blockNumber;
            }
            set
            {
                this._blockNumber = value;
            }
        }
        
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
        
        public override string TypeName()
        {
            return "PriorLock";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BlockNumber.Encode());
            result.AddRange(Balance.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BlockNumber = new Ajuna.NetApi.Model.Types.Primitive.U32();
            BlockNumber.Decode(byteArray, ref p);
            Balance = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
