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
using SubstrateNET.NetApi.Generated.Model.PalletImOnline;
using SubstrateNET.NetApi.Generated.Model.SpAuthorityDiscovery;
using SubstrateNET.NetApi.Generated.Model.SpConsensusBabe;
using SubstrateNET.NetApi.Generated.Model.SpFinalityGrandpa;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.NodeRuntime
{
    
    
    /// <summary>
    /// >> 222 - Composite[node_runtime.SessionKeys]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class SessionKeys : BaseType
    {
        
        /// <summary>
        /// >> grandpa
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpFinalityGrandpa.Public _grandpa;
        
        /// <summary>
        /// >> babe
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.Public _babe;
        
        /// <summary>
        /// >> im_online
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletImOnline.Public _imOnline;
        
        /// <summary>
        /// >> authority_discovery
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpAuthorityDiscovery.Public _authorityDiscovery;
        
        public SubstrateNET.NetApi.Generated.Model.SpFinalityGrandpa.Public Grandpa
        {
            get
            {
                return this._grandpa;
            }
            set
            {
                this._grandpa = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.Public Babe
        {
            get
            {
                return this._babe;
            }
            set
            {
                this._babe = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletImOnline.Public ImOnline
        {
            get
            {
                return this._imOnline;
            }
            set
            {
                this._imOnline = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.SpAuthorityDiscovery.Public AuthorityDiscovery
        {
            get
            {
                return this._authorityDiscovery;
            }
            set
            {
                this._authorityDiscovery = value;
            }
        }
        
        public override string TypeName()
        {
            return "SessionKeys";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Grandpa.Encode());
            result.AddRange(Babe.Encode());
            result.AddRange(ImOnline.Encode());
            result.AddRange(AuthorityDiscovery.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Grandpa = new SubstrateNET.NetApi.Generated.Model.SpFinalityGrandpa.Public();
            Grandpa.Decode(byteArray, ref p);
            Babe = new SubstrateNET.NetApi.Generated.Model.SpConsensusBabe.Public();
            Babe.Decode(byteArray, ref p);
            ImOnline = new SubstrateNET.NetApi.Generated.Model.PalletImOnline.Public();
            ImOnline.Decode(byteArray, ref p);
            AuthorityDiscovery = new SubstrateNET.NetApi.Generated.Model.SpAuthorityDiscovery.Public();
            AuthorityDiscovery.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
