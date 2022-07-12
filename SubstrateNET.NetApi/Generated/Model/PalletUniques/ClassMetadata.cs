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


namespace SubstrateNET.NetApi.Generated.Model.PalletUniques
{
    
    
    /// <summary>
    /// >> 555 - Composite[pallet_uniques.types.ClassMetadata]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ClassMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> data
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT1 _data;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _isFrozen;
        
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
        
        public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT1 Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool IsFrozen
        {
            get
            {
                return this._isFrozen;
            }
            set
            {
                this._isFrozen = value;
            }
        }
        
        public override string TypeName()
        {
            return "ClassMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            result.AddRange(IsFrozen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Data = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT1();
            Data.Decode(byteArray, ref p);
            IsFrozen = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
