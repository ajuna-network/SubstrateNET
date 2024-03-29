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
    /// ITechnicalMembershipStorage interface definition.
    /// </summary>
    public interface ITechnicalMembershipStorage : IStorage
    {
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetPrime();
    }
    
    /// <summary>
    /// TechnicalMembershipStorage class definition.
    /// </summary>
    public sealed class TechnicalMembershipStorage : ITechnicalMembershipStorage
    {
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> _primeTypedStorage;
        
        /// <summary>
        /// TechnicalMembershipStorage constructor.
        /// </summary>
        public TechnicalMembershipStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MembersTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21>("TechnicalMembership.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>("TechnicalMembership.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21> MembersTypedStorage
        {
            get
            {
                return _membersTypedStorage;
            }
            set
            {
                _membersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _primeTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> PrimeTypedStorage
        {
            get
            {
                return _primeTypedStorage;
            }
            set
            {
                _primeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MembersTypedStorage.InitializeAsync("TechnicalMembership", "Members");
            await PrimeTypedStorage.InitializeAsync("TechnicalMembership", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalMembership.Members
        /// </summary>
        [StorageChange("TechnicalMembership", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT21 GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalMembership.Prime
        /// </summary>
        [StorageChange("TechnicalMembership", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}
