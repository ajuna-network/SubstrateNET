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
    /// IAllianceStorage interface definition.
    /// </summary>
    public interface IAllianceStorage : IStorage
    {
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid GetRule();
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44 GetAnnouncements();
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetDepositOf(string key);
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45 GetMembers(string key);
        
        /// <summary>
        /// >> RetiringMembers
        ///  A set of members who gave a retirement notice. They can retire after the end of retirement
        ///  period stored as a future block number.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetRetiringMembers(string key);
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17 GetUnscrupulousAccounts();
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46 GetUnscrupulousWebsites();
    }
    
    /// <summary>
    /// AllianceStorage class definition.
    /// </summary>
    public sealed class AllianceStorage : IAllianceStorage
    {
        
        /// <summary>
        /// _ruleTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid> _ruleTypedStorage;
        
        /// <summary>
        /// _announcementsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44> _announcementsTypedStorage;
        
        /// <summary>
        /// _depositOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _depositOfTypedStorage;
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45> _membersTypedStorage;
        
        /// <summary>
        /// _retiringMembersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _retiringMembersTypedStorage;
        
        /// <summary>
        /// _unscrupulousAccountsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17> _unscrupulousAccountsTypedStorage;
        
        /// <summary>
        /// _unscrupulousWebsitesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46> _unscrupulousWebsitesTypedStorage;
        
        /// <summary>
        /// AllianceStorage constructor.
        /// </summary>
        public AllianceStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.RuleTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid>("Alliance.Rule", storageDataProvider, storageChangeDelegates);
            this.AnnouncementsTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44>("Alliance.Announcements", storageDataProvider, storageChangeDelegates);
            this.DepositOfTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("Alliance.DepositOf", storageDataProvider, storageChangeDelegates);
            this.MembersTypedStorage = new TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45>("Alliance.Members", storageDataProvider, storageChangeDelegates);
            this.RetiringMembersTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Alliance.RetiringMembers", storageDataProvider, storageChangeDelegates);
            this.UnscrupulousAccountsTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17>("Alliance.UnscrupulousAccounts", storageDataProvider, storageChangeDelegates);
            this.UnscrupulousWebsitesTypedStorage = new TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46>("Alliance.UnscrupulousWebsites", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _ruleTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid> RuleTypedStorage
        {
            get
            {
                return _ruleTypedStorage;
            }
            set
            {
                _ruleTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _announcementsTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44> AnnouncementsTypedStorage
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
        /// _depositOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> DepositOfTypedStorage
        {
            get
            {
                return _depositOfTypedStorage;
            }
            set
            {
                _depositOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedMapStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45> MembersTypedStorage
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
        /// _retiringMembersTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> RetiringMembersTypedStorage
        {
            get
            {
                return _retiringMembersTypedStorage;
            }
            set
            {
                _retiringMembersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unscrupulousAccountsTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17> UnscrupulousAccountsTypedStorage
        {
            get
            {
                return _unscrupulousAccountsTypedStorage;
            }
            set
            {
                _unscrupulousAccountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unscrupulousWebsitesTypedStorage property
        /// </summary>
        public TypedStorage<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46> UnscrupulousWebsitesTypedStorage
        {
            get
            {
                return _unscrupulousWebsitesTypedStorage;
            }
            set
            {
                _unscrupulousWebsitesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await RuleTypedStorage.InitializeAsync("Alliance", "Rule");
            await AnnouncementsTypedStorage.InitializeAsync("Alliance", "Announcements");
            await DepositOfTypedStorage.InitializeAsync("Alliance", "DepositOf");
            await MembersTypedStorage.InitializeAsync("Alliance", "Members");
            await RetiringMembersTypedStorage.InitializeAsync("Alliance", "RetiringMembers");
            await UnscrupulousAccountsTypedStorage.InitializeAsync("Alliance", "UnscrupulousAccounts");
            await UnscrupulousWebsitesTypedStorage.InitializeAsync("Alliance", "UnscrupulousWebsites");
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Rule
        /// </summary>
        [StorageChange("Alliance", "Rule")]
        public void OnUpdateRule(string data)
        {
            RuleTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid GetRule()
        {
            return RuleTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Announcements
        /// </summary>
        [StorageChange("Alliance", "Announcements")]
        public void OnUpdateAnnouncements(string data)
        {
            AnnouncementsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44 GetAnnouncements()
        {
            return AnnouncementsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.DepositOf
        /// </summary>
        [StorageChange("Alliance", "DepositOf")]
        public void OnUpdateDepositOf(string key, string data)
        {
            DepositOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetDepositOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DepositOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Members
        /// </summary>
        [StorageChange("Alliance", "Members")]
        public void OnUpdateMembers(string key, string data)
        {
            MembersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45 GetMembers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MembersTypedStorage.Dictionary.TryGetValue(key, out SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.RetiringMembers
        /// </summary>
        [StorageChange("Alliance", "RetiringMembers")]
        public void OnUpdateRetiringMembers(string key, string data)
        {
            RetiringMembersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> RetiringMembers
        ///  A set of members who gave a retirement notice. They can retire after the end of retirement
        ///  period stored as a future block number.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetRetiringMembers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RetiringMembersTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.UnscrupulousAccounts
        /// </summary>
        [StorageChange("Alliance", "UnscrupulousAccounts")]
        public void OnUpdateUnscrupulousAccounts(string data)
        {
            UnscrupulousAccountsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17 GetUnscrupulousAccounts()
        {
            return UnscrupulousAccountsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.UnscrupulousWebsites
        /// </summary>
        [StorageChange("Alliance", "UnscrupulousWebsites")]
        public void OnUpdateUnscrupulousWebsites(string data)
        {
            UnscrupulousWebsitesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46 GetUnscrupulousWebsites()
        {
            return UnscrupulousWebsitesTypedStorage.Get();
        }
    }
}
