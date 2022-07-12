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
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletUniques
{
    
    
    /// <summary>
    /// >> 562 - Composite[pallet_uniques.types.ItemDetails]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ItemDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 _owner;
        
        /// <summary>
        /// >> approved
        /// </summary>
        private BaseOpt<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> _approved;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _isFrozen;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public BaseOpt<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> Approved
        {
            get
            {
                return this._approved;
            }
            set
            {
                this._approved = value;
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
        
        public override string TypeName()
        {
            return "ItemDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Approved.Encode());
            result.AddRange(IsFrozen.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32();
            Owner.Decode(byteArray, ref p);
            Approved = new BaseOpt<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32>();
            Approved.Decode(byteArray, ref p);
            IsFrozen = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
