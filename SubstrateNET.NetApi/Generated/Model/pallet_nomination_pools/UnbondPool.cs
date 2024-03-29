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


namespace SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> 658 - Composite[pallet_nomination_pools.UnbondPool]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class UnbondPool : BaseType
    {
        
        /// <summary>
        /// >> points
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _points;
        
        /// <summary>
        /// >> balance
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _balance;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Points
        {
            get
            {
                return this._points;
            }
            set
            {
                this._points = value;
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
            return "UnbondPool";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Points.Encode());
            result.AddRange(Balance.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Points = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Points.Decode(byteArray, ref p);
            Balance = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
