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


namespace SubstrateNET.NetApi.Generated.Model.PalletAssetTxPayment
{
    
    
    /// <summary>
    /// >> 677 - Composite[pallet_asset_tx_payment.ChargeAssetTxPayment]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ChargeAssetTxPayment : BaseType
    {
        
        /// <summary>
        /// >> tip
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _tip;
        
        /// <summary>
        /// >> asset_id
        /// </summary>
        private BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _assetId;
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Tip
        {
            get
            {
                return this._tip;
            }
            set
            {
                this._tip = value;
            }
        }
        
        public BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> AssetId
        {
            get
            {
                return this._assetId;
            }
            set
            {
                this._assetId = value;
            }
        }
        
        public override string TypeName()
        {
            return "ChargeAssetTxPayment";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Tip.Encode());
            result.AddRange(AssetId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Tip = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Tip.Decode(byteArray, ref p);
            AssetId = new BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            AssetId.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
