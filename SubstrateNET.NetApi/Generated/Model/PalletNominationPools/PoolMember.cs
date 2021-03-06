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
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletNominationPools
{
    
    
    /// <summary>
    /// >> 638 - Composite[pallet_nomination_pools.PoolMember]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PoolMember : BaseType
    {
        
        /// <summary>
        /// >> pool_id
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _poolId;
        
        /// <summary>
        /// >> points
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _points;
        
        /// <summary>
        /// >> reward_pool_total_earnings
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _rewardPoolTotalEarnings;
        
        /// <summary>
        /// >> unbonding_eras
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedBTreeMapT2 _unbondingEras;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 PoolId
        {
            get
            {
                return this._poolId;
            }
            set
            {
                this._poolId = value;
            }
        }
        
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
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 RewardPoolTotalEarnings
        {
            get
            {
                return this._rewardPoolTotalEarnings;
            }
            set
            {
                this._rewardPoolTotalEarnings = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedBTreeMapT2 UnbondingEras
        {
            get
            {
                return this._unbondingEras;
            }
            set
            {
                this._unbondingEras = value;
            }
        }
        
        public override string TypeName()
        {
            return "PoolMember";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PoolId.Encode());
            result.AddRange(Points.Encode());
            result.AddRange(RewardPoolTotalEarnings.Encode());
            result.AddRange(UnbondingEras.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PoolId = new Ajuna.NetApi.Model.Types.Primitive.U32();
            PoolId.Decode(byteArray, ref p);
            Points = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Points.Decode(byteArray, ref p);
            RewardPoolTotalEarnings = new Ajuna.NetApi.Model.Types.Primitive.U128();
            RewardPoolTotalEarnings.Decode(byteArray, ref p);
            UnbondingEras = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedBTreeMapT2();
            UnbondingEras.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
