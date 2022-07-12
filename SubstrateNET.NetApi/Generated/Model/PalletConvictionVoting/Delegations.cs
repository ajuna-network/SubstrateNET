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


namespace SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting
{
    
    
    /// <summary>
    /// >> 597 - Composite[pallet_conviction_voting.types.Delegations]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Delegations : BaseType
    {
        
        /// <summary>
        /// >> votes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _votes;
        
        /// <summary>
        /// >> capital
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _capital;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Votes
        {
            get
            {
                return this._votes;
            }
            set
            {
                this._votes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Capital
        {
            get
            {
                return this._capital;
            }
            set
            {
                this._capital = value;
            }
        }
        
        public override string TypeName()
        {
            return "Delegations";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Votes.Encode());
            result.AddRange(Capital.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Votes = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Votes.Decode(byteArray, ref p);
            Capital = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Capital.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
