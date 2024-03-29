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
    /// >> 654 - Composite[pallet_nomination_pools.BondedPoolInner]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BondedPoolInner : BaseType
    {
        
        /// <summary>
        /// >> points
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _points;
        
        /// <summary>
        /// >> state
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.EnumPoolState _state;
        
        /// <summary>
        /// >> member_counter
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _memberCounter;
        
        /// <summary>
        /// >> roles
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.PoolRoles _roles;
        
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
        
        public SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.EnumPoolState State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MemberCounter
        {
            get
            {
                return this._memberCounter;
            }
            set
            {
                this._memberCounter = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.PoolRoles Roles
        {
            get
            {
                return this._roles;
            }
            set
            {
                this._roles = value;
            }
        }
        
        public override string TypeName()
        {
            return "BondedPoolInner";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Points.Encode());
            result.AddRange(State.Encode());
            result.AddRange(MemberCounter.Encode());
            result.AddRange(Roles.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Points = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Points.Decode(byteArray, ref p);
            State = new SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.EnumPoolState();
            State.Decode(byteArray, ref p);
            MemberCounter = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MemberCounter.Decode(byteArray, ref p);
            Roles = new SubstrateNET.NetApi.Generated.Model.pallet_nomination_pools.PoolRoles();
            Roles.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
