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
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.PalletBagsList;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletBagsList
{
    
    
    public sealed class BagsListStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public BagsListStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("BagsList", "ListNodes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.Node)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("BagsList", "CounterForListNodes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("BagsList", "ListBags"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U64), typeof(SubstrateNET.NetApi.Generated.Model.PalletBagsList.Bag)));
        }
        
        /// <summary>
        /// >> ListNodesParams
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        public static string ListNodesParams(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("BagsList", "ListNodes", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ListNodes
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletBagsList.Node> ListNodes(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = BagsListStorage.ListNodesParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletBagsList.Node>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForListNodesParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForListNodesParams()
        {
            return RequestGenerator.GetStorage("BagsList", "CounterForListNodes", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForListNodes
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForListNodes(CancellationToken token)
        {
            string parameters = BagsListStorage.CounterForListNodesParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ListBagsParams
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        public static string ListBagsParams(Ajuna.NetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("BagsList", "ListBags", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ListBags
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletBagsList.Bag> ListBags(Ajuna.NetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = BagsListStorage.ListBagsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletBagsList.Bag>(parameters, token);
        }
    }
    
    public sealed class BagsListCalls
    {
        
        /// <summary>
        /// >> rebag
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Rebag(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 dislocated)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dislocated.Encode());
            return new Method(42, "BagsList", 0, "rebag", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> put_in_front_of
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PutInFrontOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 lighter)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(lighter.Encode());
            return new Method(42, "BagsList", 1, "put_in_front_of", byteArray.ToArray());
        }
    }
    
    public enum BagsListErrors
    {
        
        /// <summary>
        /// >> List
        /// A error in the list interface implementation.
        /// </summary>
        List,
    }
}
