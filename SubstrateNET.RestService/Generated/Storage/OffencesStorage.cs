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
using SubstrateNET.NetApi.Generated.Model.Base;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using SubstrateNET.NetApi.Generated.Model.SpStaking;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IOffencesStorage interface definition.
    /// </summary>
    public interface IOffencesStorage : IStorage
    {
        
        /// <summary>
        /// >> Reports
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails GetReports(string key);
        
        /// <summary>
        /// >> ConcurrentReportsIndex
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256> GetConcurrentReportsIndex(string key);
        
        /// <summary>
        /// >> ReportsByKindIndex
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> GetReportsByKindIndex(string key);
    }
    
    /// <summary>
    /// OffencesStorage class definition.
    /// </summary>
    public sealed class OffencesStorage : IOffencesStorage
    {
        
        /// <summary>
        /// _reportsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails> _reportsTypedStorage;
        
        /// <summary>
        /// _concurrentReportsIndexTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256>> _concurrentReportsIndexTypedStorage;
        
        /// <summary>
        /// _reportsByKindIndexTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> _reportsByKindIndexTypedStorage;
        
        /// <summary>
        /// OffencesStorage constructor.
        /// </summary>
        public OffencesStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.ReportsTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails>("Offences.Reports", storageDataProvider, storageChangeDelegate);
            this.ConcurrentReportsIndexTypedStorage = new TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256>>("Offences.ConcurrentReportsIndex", storageDataProvider, storageChangeDelegate);
            this.ReportsByKindIndexTypedStorage = new TypedMapStorage<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>("Offences.ReportsByKindIndex", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _reportsTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails> ReportsTypedStorage
        {
            get
            {
                return _reportsTypedStorage;
            }
            set
            {
                _reportsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _concurrentReportsIndexTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256>> ConcurrentReportsIndexTypedStorage
        {
            get
            {
                return _concurrentReportsIndexTypedStorage;
            }
            set
            {
                _concurrentReportsIndexTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reportsByKindIndexTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> ReportsByKindIndexTypedStorage
        {
            get
            {
                return _reportsByKindIndexTypedStorage;
            }
            set
            {
                _reportsByKindIndexTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ReportsTypedStorage.InitializeAsync("Offences", "Reports");
            await ConcurrentReportsIndexTypedStorage.InitializeAsync("Offences", "ConcurrentReportsIndex");
            await ReportsByKindIndexTypedStorage.InitializeAsync("Offences", "ReportsByKindIndex");
        }
        
        /// <summary>
        /// Implements any storage change for Offences.Reports
        /// </summary>
        [StorageChange("Offences", "Reports")]
        public void OnUpdateReports(string key, string data)
        {
            ReportsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Reports
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails GetReports(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReportsTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.SpStaking.OffenceDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Offences.ConcurrentReportsIndex
        /// </summary>
        [StorageChange("Offences", "ConcurrentReportsIndex")]
        public void OnUpdateConcurrentReportsIndex(string key, string data)
        {
            ConcurrentReportsIndexTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndex
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        public BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256> GetConcurrentReportsIndex(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ConcurrentReportsIndexTypedStorage.Dictionary.TryGetValue(key, out BaseVec<SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Offences.ReportsByKindIndex
        /// </summary>
        [StorageChange("Offences", "ReportsByKindIndex")]
        public void OnUpdateReportsByKindIndex(string key, string data)
        {
            ReportsByKindIndexTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReportsByKindIndex
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        public BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> GetReportsByKindIndex(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReportsByKindIndexTypedStorage.Dictionary.TryGetValue(key, out BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> result))
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
