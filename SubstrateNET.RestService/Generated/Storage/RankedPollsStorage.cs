//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IRankedPollsStorage interface definition.
    /// </summary>
    public interface IRankedPollsStorage : IStorage
    {
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount();
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo GetReferendumInfoFor(string key);
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48 GetTrackQueue(string key);
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetDecidingCount(string key);
    }
    
    /// <summary>
    /// RankedPollsStorage class definition.
    /// </summary>
    public sealed class RankedPollsStorage : IRankedPollsStorage
    {
        
        /// <summary>
        /// _referendumCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _referendumCountTypedStorage;
        
        /// <summary>
        /// _referendumInfoForTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo> _referendumInfoForTypedStorage;
        
        /// <summary>
        /// _trackQueueTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48> _trackQueueTypedStorage;
        
        /// <summary>
        /// _decidingCountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _decidingCountTypedStorage;
        
        /// <summary>
        /// RankedPollsStorage constructor.
        /// </summary>
        public RankedPollsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ReferendumCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("RankedPolls.ReferendumCount", storageDataProvider, storageChangeDelegates);
            this.ReferendumInfoForTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo>("RankedPolls.ReferendumInfoFor", storageDataProvider, storageChangeDelegates);
            this.TrackQueueTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48>("RankedPolls.TrackQueue", storageDataProvider, storageChangeDelegates);
            this.DecidingCountTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("RankedPolls.DecidingCount", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _referendumCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ReferendumCountTypedStorage
        {
            get
            {
                return _referendumCountTypedStorage;
            }
            set
            {
                _referendumCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumInfoForTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo> ReferendumInfoForTypedStorage
        {
            get
            {
                return _referendumInfoForTypedStorage;
            }
            set
            {
                _referendumInfoForTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _trackQueueTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48> TrackQueueTypedStorage
        {
            get
            {
                return _trackQueueTypedStorage;
            }
            set
            {
                _trackQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _decidingCountTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> DecidingCountTypedStorage
        {
            get
            {
                return _decidingCountTypedStorage;
            }
            set
            {
                _decidingCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ReferendumCountTypedStorage.InitializeAsync("RankedPolls", "ReferendumCount");
            await ReferendumInfoForTypedStorage.InitializeAsync("RankedPolls", "ReferendumInfoFor");
            await TrackQueueTypedStorage.InitializeAsync("RankedPolls", "TrackQueue");
            await DecidingCountTypedStorage.InitializeAsync("RankedPolls", "DecidingCount");
        }
        
        /// <summary>
        /// Implements any storage change for RankedPolls.ReferendumCount
        /// </summary>
        [StorageChange("RankedPolls", "ReferendumCount")]
        public void OnUpdateReferendumCount(string data)
        {
            ReferendumCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount()
        {
            return ReferendumCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for RankedPolls.ReferendumInfoFor
        /// </summary>
        [StorageChange("RankedPolls", "ReferendumInfoFor")]
        public void OnUpdateReferendumInfoFor(string key, string data)
        {
            ReferendumInfoForTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo GetReferendumInfoFor(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReferendumInfoForTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for RankedPolls.TrackQueue
        /// </summary>
        [StorageChange("RankedPolls", "TrackQueue")]
        public void OnUpdateTrackQueue(string key, string data)
        {
            TrackQueueTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48 GetTrackQueue(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TrackQueueTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT48 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for RankedPolls.DecidingCount
        /// </summary>
        [StorageChange("RankedPolls", "DecidingCount")]
        public void OnUpdateDecidingCount(string key, string data)
        {
            DecidingCountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetDecidingCount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DecidingCountTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
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
