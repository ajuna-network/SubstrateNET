//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IProxyStorage interface definition.
    /// </summary>
    public interface IProxyStorage : IStorage
    {
        
        /// <summary>
        /// >> Proxies
        ///  The set of account proxies. Maps the account which has delegated to the accounts
        ///  which are being delegated to, together with the amount held on deposit.
        /// </summary>
        BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128> GetProxies(string key);
        
        /// <summary>
        /// >> Announcements
        ///  The announcements made by the proxy (key).
        /// </summary>
        BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128> GetAnnouncements(string key);
    }
    
    /// <summary>
    /// ProxyStorage class definition.
    /// </summary>
    public sealed class ProxyStorage : IProxyStorage
    {
        
        /// <summary>
        /// _proxiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128>> _proxiesTypedStorage;
        
        /// <summary>
        /// _announcementsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128>> _announcementsTypedStorage;
        
        /// <summary>
        /// ProxyStorage constructor.
        /// </summary>
        public ProxyStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.ProxiesTypedStorage = new TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128>>("Proxy.Proxies", storageDataProvider, storageChangeDelegate);
            this.AnnouncementsTypedStorage = new TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128>>("Proxy.Announcements", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _proxiesTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128>> ProxiesTypedStorage
        {
            get
            {
                return _proxiesTypedStorage;
            }
            set
            {
                _proxiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _announcementsTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128>> AnnouncementsTypedStorage
        {
            get
            {
                return _announcementsTypedStorage;
            }
            set
            {
                _announcementsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ProxiesTypedStorage.InitializeAsync("Proxy", "Proxies");
            await AnnouncementsTypedStorage.InitializeAsync("Proxy", "Announcements");
        }
        
        /// <summary>
        /// Implements any storage change for Proxy.Proxies
        /// </summary>
        [StorageChange("Proxy", "Proxies")]
        public void OnUpdateProxies(string key, string data)
        {
            ProxiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Proxies
        ///  The set of account proxies. Maps the account which has delegated to the accounts
        ///  which are being delegated to, together with the amount held on deposit.
        /// </summary>
        public BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128> GetProxies(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProxiesTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT28,Ajuna.NetApi.Model.Types.Primitive.U128> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Proxy.Announcements
        /// </summary>
        [StorageChange("Proxy", "Announcements")]
        public void OnUpdateAnnouncements(string key, string data)
        {
            AnnouncementsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Announcements
        ///  The announcements made by the proxy (key).
        /// </summary>
        public BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128> GetAnnouncements(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AnnouncementsTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT29,Ajuna.NetApi.Model.Types.Primitive.U128> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
