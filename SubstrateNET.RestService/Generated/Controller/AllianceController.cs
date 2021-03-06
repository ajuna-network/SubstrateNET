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
using Microsoft.AspNetCore.Mvc;
using SubstrateNET.NetApi.Generated.Model.PalletAlliance;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
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
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.Cid), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "RuleParams")]
        public IActionResult GetRule()
        {
            return this.Ok(_allianceStorage.GetRule());
        }
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        [HttpGet("Announcements")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT39), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "AnnouncementsParams")]
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
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "DepositOfParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetDepositOf(string key)
        {
            return this.Ok(_allianceStorage.GetDepositOf(key));
        }
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT40), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "MembersParams", typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.EnumMemberRole))]
        public IActionResult GetMembers(string key)
        {
            return this.Ok(_allianceStorage.GetMembers(key));
        }
        
        /// <summary>
        /// >> UpForKicking
        ///  A set of members that are (potentially) being kicked out. They cannot retire until the
        ///  motion is settled.
        /// </summary>
        [HttpGet("UpForKicking")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "UpForKickingParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetUpForKicking(string key)
        {
            return this.Ok(_allianceStorage.GetUpForKicking(key));
        }
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        [HttpGet("UnscrupulousAccounts")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT41), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "UnscrupulousAccountsParams")]
        public IActionResult GetUnscrupulousAccounts()
        {
            return this.Ok(_allianceStorage.GetUnscrupulousAccounts());
        }
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        [HttpGet("UnscrupulousWebsites")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT42), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletAlliance.AllianceStorage), "UnscrupulousWebsitesParams")]
        public IActionResult GetUnscrupulousWebsites()
        {
            return this.Ok(_allianceStorage.GetUnscrupulousWebsites());
        }
    }
}
