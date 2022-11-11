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
    
    
    public sealed class AllianceStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public AllianceStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "Rule"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "Announcements"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "DepositOf"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "Members"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumMemberRole), typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "RetiringMembers"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "UnscrupulousAccounts"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Alliance", "UnscrupulousWebsites"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46)));
        }
        
        /// <summary>
        /// >> RuleParams
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        public static string RuleParams()
        {
            return RequestGenerator.GetStorage("Alliance", "Rule", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid> Rule(CancellationToken token)
        {
            string parameters = AllianceStorage.RuleParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid>(parameters, token);
        }
        
        /// <summary>
        /// >> AnnouncementsParams
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        public static string AnnouncementsParams()
        {
            return RequestGenerator.GetStorage("Alliance", "Announcements", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44> Announcements(CancellationToken token)
        {
            string parameters = AllianceStorage.AnnouncementsParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44>(parameters, token);
        }
        
        /// <summary>
        /// >> DepositOfParams
        ///  Maps members to their candidacy deposit.
        /// </summary>
        public static string DepositOfParams(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Alliance", "DepositOf", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> DepositOf(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = AllianceStorage.DepositOfParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> MembersParams
        ///  Maps member type to members of each type.
        /// </summary>
        public static string MembersParams(SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumMemberRole key)
        {
            return RequestGenerator.GetStorage("Alliance", "Members", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45> Members(SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumMemberRole key, CancellationToken token)
        {
            string parameters = AllianceStorage.MembersParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45>(parameters, token);
        }
        
        /// <summary>
        /// >> RetiringMembersParams
        ///  A set of members who gave a retirement notice. They can retire after the end of retirement
        ///  period stored as a future block number.
        /// </summary>
        public static string RetiringMembersParams(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Alliance", "RetiringMembers", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> RetiringMembers
        ///  A set of members who gave a retirement notice. They can retire after the end of retirement
        ///  period stored as a future block number.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> RetiringMembers(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = AllianceStorage.RetiringMembersParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> UnscrupulousAccountsParams
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        public static string UnscrupulousAccountsParams()
        {
            return RequestGenerator.GetStorage("Alliance", "UnscrupulousAccounts", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17> UnscrupulousAccounts(CancellationToken token)
        {
            string parameters = AllianceStorage.UnscrupulousAccountsParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17>(parameters, token);
        }
        
        /// <summary>
        /// >> UnscrupulousWebsitesParams
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        public static string UnscrupulousWebsitesParams()
        {
            return RequestGenerator.GetStorage("Alliance", "UnscrupulousWebsites", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46> UnscrupulousWebsites(CancellationToken token)
        {
            string parameters = AllianceStorage.UnscrupulousWebsitesParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46>(parameters, token);
        }
    }
    
    public sealed class AllianceCalls
    {
        
        /// <summary>
        /// >> propose
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Propose(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> threshold, SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall proposal, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> length_bound)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(threshold.Encode());
            byteArray.AddRange(proposal.Encode());
            byteArray.AddRange(length_bound.Encode());
            return new Method(50, "Alliance", 0, "propose", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vote(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 proposal, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> index, Ajuna.NetApi.Model.Types.Primitive.Bool approve)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal.Encode());
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(approve.Encode());
            return new Method(50, "Alliance", 1, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> veto
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Veto(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 proposal_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_hash.Encode());
            return new Method(50, "Alliance", 2, "veto", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> close_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CloseOldWeight(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 proposal_hash, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> index, Ajuna.NetApi.Model.Types.Base.BaseCom<SubstrateNET.NetApi.Generated.Model.sp_weights.OldWeight> proposal_weight_bound, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> length_bound)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_hash.Encode());
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(proposal_weight_bound.Encode());
            byteArray.AddRange(length_bound.Encode());
            return new Method(50, "Alliance", 3, "close_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> init_members
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InitMembers(Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> founders, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> fellows, Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> allies)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(founders.Encode());
            byteArray.AddRange(fellows.Encode());
            byteArray.AddRange(allies.Encode());
            return new Method(50, "Alliance", 4, "init_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> disband
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Disband(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.DisbandWitness witness)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(witness.Encode());
            return new Method(50, "Alliance", 5, "disband", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_rule
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetRule(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid rule)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(rule.Encode());
            return new Method(50, "Alliance", 6, "set_rule", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> announce
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Announce(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid announcement)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(announcement.Encode());
            return new Method(50, "Alliance", 7, "announce", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_announcement
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveAnnouncement(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid announcement)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(announcement.Encode());
            return new Method(50, "Alliance", 8, "remove_announcement", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> join_alliance
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method JoinAlliance()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(50, "Alliance", 9, "join_alliance", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> nominate_ally
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method NominateAlly(SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(50, "Alliance", 10, "nominate_ally", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> elevate_ally
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ElevateAlly(SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress ally)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ally.Encode());
            return new Method(50, "Alliance", 11, "elevate_ally", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> give_retirement_notice
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method GiveRetirementNotice()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(50, "Alliance", 12, "give_retirement_notice", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> retire
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Retire()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(50, "Alliance", 13, "retire", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kick_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method KickMember(SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(50, "Alliance", 14, "kick_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> add_unscrupulous_items
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddUnscrupulousItems(Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem> items)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(items.Encode());
            return new Method(50, "Alliance", 15, "add_unscrupulous_items", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_unscrupulous_items
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveUnscrupulousItems(Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumUnscrupulousItem> items)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(items.Encode());
            return new Method(50, "Alliance", 16, "remove_unscrupulous_items", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> close
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Close(SubstrateNET.NetApi.Generated.Model.primitive_types.H256 proposal_hash, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> index, SubstrateNET.NetApi.Generated.Model.sp_weights.weight_v2.Weight proposal_weight_bound, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> length_bound)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_hash.Encode());
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(proposal_weight_bound.Encode());
            byteArray.AddRange(length_bound.Encode());
            return new Method(50, "Alliance", 17, "close", byteArray.ToArray());
        }
    }
    
    public enum AllianceErrors
    {
        
        /// <summary>
        /// >> AllianceNotYetInitialized
        /// The Alliance has not been initialized yet, therefore accounts cannot join it.
        /// </summary>
        AllianceNotYetInitialized,
        
        /// <summary>
        /// >> AllianceAlreadyInitialized
        /// The Alliance has been initialized, therefore cannot be initialized again.
        /// </summary>
        AllianceAlreadyInitialized,
        
        /// <summary>
        /// >> AlreadyMember
        /// Account is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> NotAlly
        /// Account is not an ally.
        /// </summary>
        NotAlly,
        
        /// <summary>
        /// >> NotFounder
        /// Account is not a founder.
        /// </summary>
        NotFounder,
        
        /// <summary>
        /// >> NoVotingRights
        /// Account does not have voting rights.
        /// </summary>
        NoVotingRights,
        
        /// <summary>
        /// >> AlreadyElevated
        /// Account is already an elevated (fellow) member.
        /// </summary>
        AlreadyElevated,
        
        /// <summary>
        /// >> AlreadyUnscrupulous
        /// Item is already listed as unscrupulous.
        /// </summary>
        AlreadyUnscrupulous,
        
        /// <summary>
        /// >> AccountNonGrata
        /// Account has been deemed unscrupulous by the Alliance and is not welcome to join or be
        /// nominated.
        /// </summary>
        AccountNonGrata,
        
        /// <summary>
        /// >> NotListedAsUnscrupulous
        /// Item has not been deemed unscrupulous.
        /// </summary>
        NotListedAsUnscrupulous,
        
        /// <summary>
        /// >> TooManyUnscrupulousItems
        /// The number of unscrupulous items exceeds `MaxUnscrupulousItems`.
        /// </summary>
        TooManyUnscrupulousItems,
        
        /// <summary>
        /// >> TooLongWebsiteUrl
        /// Length of website URL exceeds `MaxWebsiteUrlLength`.
        /// </summary>
        TooLongWebsiteUrl,
        
        /// <summary>
        /// >> InsufficientFunds
        /// Balance is insufficient for the required deposit.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> WithoutIdentityDisplayAndWebsite
        /// The account's identity does not have display field and website field.
        /// </summary>
        WithoutIdentityDisplayAndWebsite,
        
        /// <summary>
        /// >> WithoutGoodIdentityJudgement
        /// The account's identity has no good judgement.
        /// </summary>
        WithoutGoodIdentityJudgement,
        
        /// <summary>
        /// >> MissingProposalHash
        /// The proposal hash is not found.
        /// </summary>
        MissingProposalHash,
        
        /// <summary>
        /// >> NotVetoableProposal
        /// The proposal is not vetoable.
        /// </summary>
        NotVetoableProposal,
        
        /// <summary>
        /// >> MissingAnnouncement
        /// The announcement is not found.
        /// </summary>
        MissingAnnouncement,
        
        /// <summary>
        /// >> TooManyMembers
        /// Number of members exceeds `MaxMembersCount`.
        /// </summary>
        TooManyMembers,
        
        /// <summary>
        /// >> TooManyAnnouncements
        /// Number of announcements exceeds `MaxAnnouncementsCount`.
        /// </summary>
        TooManyAnnouncements,
        
        /// <summary>
        /// >> BadWitness
        /// Invalid witness data given.
        /// </summary>
        BadWitness,
        
        /// <summary>
        /// >> AlreadyRetiring
        /// Account already gave retirement notice
        /// </summary>
        AlreadyRetiring,
        
        /// <summary>
        /// >> RetirementNoticeNotGiven
        /// Account did not give a retirement notice required to retire.
        /// </summary>
        RetirementNoticeNotGiven,
        
        /// <summary>
        /// >> RetirementPeriodNotPassed
        /// Retirement period has not passed.
        /// </summary>
        RetirementPeriodNotPassed,
        
        /// <summary>
        /// >> FoundersMissing
        /// Founders must be provided to initialize the Alliance.
        /// </summary>
        FoundersMissing,
    }
}
