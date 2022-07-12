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
using SubstrateNET.NetApi.Generated.Model.PalletScheduler;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ISchedulerStorage interface definition.
    /// </summary>
    public interface ISchedulerStorage : IStorage
    {
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>> GetAgenda(string key);
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from identity to the block number and index of the task.
        /// </summary>
        BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32> GetLookup(string key);
    }
    
    /// <summary>
    /// SchedulerStorage class definition.
    /// </summary>
    public sealed class SchedulerStorage : ISchedulerStorage
    {
        
        /// <summary>
        /// _agendaTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>>> _agendaTypedStorage;
        
        /// <summary>
        /// _lookupTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>> _lookupTypedStorage;
        
        /// <summary>
        /// SchedulerStorage constructor.
        /// </summary>
        public SchedulerStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.AgendaTypedStorage = new TypedMapStorage<BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>>>("Scheduler.Agenda", storageDataProvider, storageChangeDelegate);
            this.LookupTypedStorage = new TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>("Scheduler.Lookup", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _agendaTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>>> AgendaTypedStorage
        {
            get
            {
                return _agendaTypedStorage;
            }
            set
            {
                _agendaTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lookupTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>> LookupTypedStorage
        {
            get
            {
                return _lookupTypedStorage;
            }
            set
            {
                _lookupTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AgendaTypedStorage.InitializeAsync("Scheduler", "Agenda");
            await LookupTypedStorage.InitializeAsync("Scheduler", "Lookup");
        }
        
        /// <summary>
        /// Implements any storage change for Scheduler.Agenda
        /// </summary>
        [StorageChange("Scheduler", "Agenda")]
        public void OnUpdateAgenda(string key, string data)
        {
            AgendaTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        public BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>> GetAgenda(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AgendaTypedStorage.Dictionary.TryGetValue(key, out BaseVec<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletScheduler.ScheduledV3>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Scheduler.Lookup
        /// </summary>
        [StorageChange("Scheduler", "Lookup")]
        public void OnUpdateLookup(string key, string data)
        {
            LookupTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from identity to the block number and index of the task.
        /// </summary>
        public BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32> GetLookup(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LookupTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32> result))
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
