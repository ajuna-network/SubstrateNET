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


namespace SubstrateNET.NetApi.Generated.Model.pallet_grandpa
{
    
    
    /// <summary>
    /// >> 472 - Composite[pallet_grandpa.StoredPendingChange]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class StoredPendingChange : BaseType
    {
        
        /// <summary>
        /// >> scheduled_at
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _scheduledAt;
        
        /// <summary>
        /// >> delay
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _delay;
        
        /// <summary>
        /// >> next_authorities
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec.WeakBoundedVecT3 _nextAuthorities;
        
        /// <summary>
        /// >> forced
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _forced;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ScheduledAt
        {
            get
            {
                return this._scheduledAt;
            }
            set
            {
                this._scheduledAt = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Delay
        {
            get
            {
                return this._delay;
            }
            set
            {
                this._delay = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec.WeakBoundedVecT3 NextAuthorities
        {
            get
            {
                return this._nextAuthorities;
            }
            set
            {
                this._nextAuthorities = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> Forced
        {
            get
            {
                return this._forced;
            }
            set
            {
                this._forced = value;
            }
        }
        
        public override string TypeName()
        {
            return "StoredPendingChange";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ScheduledAt.Encode());
            result.AddRange(Delay.Encode());
            result.AddRange(NextAuthorities.Encode());
            result.AddRange(Forced.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ScheduledAt = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ScheduledAt.Decode(byteArray, ref p);
            Delay = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Delay.Decode(byteArray, ref p);
            NextAuthorities = new SubstrateNET.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec.WeakBoundedVecT3();
            NextAuthorities.Decode(byteArray, ref p);
            Forced = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Forced.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}