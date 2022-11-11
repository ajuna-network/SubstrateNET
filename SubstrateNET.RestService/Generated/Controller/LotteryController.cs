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
    /// LotteryController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class LotteryController : ControllerBase
    {
        
        private ILotteryStorage _lotteryStorage;
        
        /// <summary>
        /// LotteryController constructor.
        /// </summary>
        public LotteryController(ILotteryStorage lotteryStorage)
        {
            _lotteryStorage = lotteryStorage;
        }
        
        /// <summary>
        /// >> LotteryIndex
        /// </summary>
        [HttpGet("LotteryIndex")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "LotteryIndexParams")]
        public IActionResult GetLotteryIndex()
        {
            return this.Ok(_lotteryStorage.GetLotteryIndex());
        }
        
        /// <summary>
        /// >> Lottery
        ///  The configuration for the current lottery.
        /// </summary>
        [HttpGet("Lottery")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.pallet_lottery.LotteryConfig), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "LotteryParams")]
        public IActionResult GetLottery()
        {
            return this.Ok(_lotteryStorage.GetLottery());
        }
        
        /// <summary>
        /// >> Participants
        ///  Users who have purchased a ticket. (Lottery Index, Tickets Purchased)
        /// </summary>
        [HttpGet("Participants")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT36>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "ParticipantsParams", typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetParticipants(string key)
        {
            return this.Ok(_lotteryStorage.GetParticipants(key));
        }
        
        /// <summary>
        /// >> TicketsCount
        ///  Total number of tickets sold.
        /// </summary>
        [HttpGet("TicketsCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "TicketsCountParams")]
        public IActionResult GetTicketsCount()
        {
            return this.Ok(_lotteryStorage.GetTicketsCount());
        }
        
        /// <summary>
        /// >> Tickets
        ///  Each ticket's owner.
        /// 
        ///  May have residual storage from previous lotteries. Use `TicketsCount` to see which ones
        ///  are actually valid ticket mappings.
        /// </summary>
        [HttpGet("Tickets")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "TicketsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetTickets(string key)
        {
            return this.Ok(_lotteryStorage.GetTickets(key));
        }
        
        /// <summary>
        /// >> CallIndices
        ///  The calls stored in this pallet to be used in an active lottery if configured
        ///  by `Config::ValidateCall`.
        /// </summary>
        [HttpGet("CallIndices")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT36), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Storage.LotteryStorage), "CallIndicesParams")]
        public IActionResult GetCallIndices()
        {
            return this.Ok(_lotteryStorage.GetCallIndices());
        }
    }
}
