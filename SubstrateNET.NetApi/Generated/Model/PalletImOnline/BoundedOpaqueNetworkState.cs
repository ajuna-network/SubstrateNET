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
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletImOnline
{
    
    
    /// <summary>
    /// >> 497 - Composite[pallet_im_online.BoundedOpaqueNetworkState]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedOpaqueNetworkState : BaseType
    {
        
        /// <summary>
        /// >> peer_id
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT5 _peerId;
        
        /// <summary>
        /// >> external_addresses
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT6 _externalAddresses;
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT5 PeerId
        {
            get
            {
                return this._peerId;
            }
            set
            {
                this._peerId = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT6 ExternalAddresses
        {
            get
            {
                return this._externalAddresses;
            }
            set
            {
                this._externalAddresses = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedOpaqueNetworkState";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PeerId.Encode());
            result.AddRange(ExternalAddresses.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PeerId = new SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT5();
            PeerId.Decode(byteArray, ref p);
            ExternalAddresses = new SubstrateNET.NetApi.Generated.Model.SpRuntime.WeakBoundedVecT6();
            ExternalAddresses.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
