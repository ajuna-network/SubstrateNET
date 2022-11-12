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
using Microsoft.AspNetCore.Mvc;
using SubstrateNET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SubstrateNET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AllianceController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AllianceController : ControllerBase
    {
        
        private IAllianceStorage _allianceStorage;
        
        /// <summary>
        /// AllianceController constructor.
        /// </summary>
        public AllianceController(IAllianceStorage allianceStorage)
        {
            _allianceStorage = allianceStorage;
        }
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        [HttpGet("Rule")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_alliance.types.Cid), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "RuleParams")]
        public IActionResult GetRule()
        {
            return this.Ok(_allianceStorage.GetRule());
        }
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        [HttpGet("Announcements")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT44), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "AnnouncementsParams")]
        public IActionResult GetAnnouncements()
        {
            return this.Ok(_allianceStorage.GetAnnouncements());
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        [HttpGet("DepositOf")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "DepositOfParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetDepositOf(string key)
        {
            return this.Ok(_allianceStorage.GetDepositOf(key));
        }
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT45), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "MembersParams", typeof(SubstrateNET.NetApi.Generated.Model.pallet_alliance.EnumMemberRole))]
        public IActionResult GetMembers(string key)
        {
            return this.Ok(_allianceStorage.GetMembers(key));
        }
        
        /// <summary>
        /// >> RetiringMembers
        ///  A set of members who gave a retirement notice. They can retire after the end of retirement
        ///  period stored as a future block number.
        /// </summary>
        [HttpGet("RetiringMembers")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "RetiringMembersParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetRetiringMembers(string key)
        {
            return this.Ok(_allianceStorage.GetRetiringMembers(key));
        }
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        [HttpGet("UnscrupulousAccounts")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT17), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "UnscrupulousAccountsParams")]
        public IActionResult GetUnscrupulousAccounts()
        {
            return this.Ok(_allianceStorage.GetUnscrupulousAccounts());
        }
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        [HttpGet("UnscrupulousWebsites")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT46), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.AllianceStorage), "UnscrupulousWebsitesParams")]
        public IActionResult GetUnscrupulousWebsites()
        {
            return this.Ok(_allianceStorage.GetUnscrupulousWebsites());
        }
    }
}
