//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Storage
{
    
    
    public sealed class RemarkStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public RemarkStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    public sealed class RemarkCalls
    {
        
        /// <summary>
        /// >> store
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Store(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> remark)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remark.Encode());
            return new Method(46, "Remark", 0, "store", byteArray.ToArray());
        }
    }
    
    public enum RemarkErrors
    {
        
        /// <summary>
        /// >> Empty
        /// Attempting to store empty data.
        /// </summary>
        Empty,
        
        /// <summary>
        /// >> BadContext
        /// Attempted to call `store` outside of block execution.
        /// </summary>
        BadContext,
    }
}