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


namespace SubstrateNET.NetApi.Generated.Model.pallet_scheduler
{
    
    
    /// <summary>
    /// >> 545 - Composite[pallet_scheduler.Scheduled]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Scheduled : BaseType
    {
        
        /// <summary>
        /// >> maybe_id
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Types.Base.Arr32U8> _maybeId;
        
        /// <summary>
        /// >> priority
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _priority;
        
        /// <summary>
        /// >> call
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded _call;
        
        /// <summary>
        /// >> maybe_periodic
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> _maybePeriodic;
        
        /// <summary>
        /// >> origin
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumOriginCaller _origin;
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Types.Base.Arr32U8> MaybeId
        {
            get
            {
                return this._maybeId;
            }
            set
            {
                this._maybeId = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                this._priority = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded Call
        {
            get
            {
                return this._call;
            }
            set
            {
                this._call = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> MaybePeriodic
        {
            get
            {
                return this._maybePeriodic;
            }
            set
            {
                this._maybePeriodic = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumOriginCaller Origin
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
        
        public override string TypeName()
        {
            return "Scheduled";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaybeId.Encode());
            result.AddRange(Priority.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(MaybePeriodic.Encode());
            result.AddRange(Origin.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaybeId = new Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Types.Base.Arr32U8>();
            MaybeId.Decode(byteArray, ref p);
            Priority = new Ajuna.NetApi.Model.Types.Primitive.U8();
            Priority.Decode(byteArray, ref p);
            Call = new SubstrateNET.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded();
            Call.Decode(byteArray, ref p);
            MaybePeriodic = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>();
            MaybePeriodic.Decode(byteArray, ref p);
            Origin = new SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumOriginCaller();
            Origin.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}