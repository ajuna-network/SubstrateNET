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
using SubstrateNET.NetApi.Generated.Model.FrameSupport;
using SubstrateNET.NetApi.Generated.Model.PalletLottery;
using SubstrateNET.NetApi.Generated.Model.SpCore;
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
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "LotteryIndexParams")]
        public IActionResult GetLotteryIndex()
        {
            return this.Ok(_lotteryStorage.GetLotteryIndex());
        }
        
        /// <summary>
        /// >> Lottery
        ///  The configuration for the current lottery.
        /// </summary>
        [HttpGet("Lottery")]
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryConfig), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "LotteryParams")]
        public IActionResult GetLottery()
        {
            return this.Ok(_lotteryStorage.GetLottery());
        }
        
        /// <summary>
        /// >> Participants
        ///  Users who have purchased a ticket. (Lottery Index, Tickets Purchased)
        /// </summary>
        [HttpGet("Participants")]
        [ProducesResponseType(typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT26>), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "ParticipantsParams", typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32))]
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
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "TicketsCountParams")]
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
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "TicketsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
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
        [ProducesResponseType(typeof(SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT26), 200)]
        [StorageKeyBuilder(typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryStorage), "CallIndicesParams")]
        public IActionResult GetCallIndices()
        {
            return this.Ok(_lotteryStorage.GetCallIndices());
        }
    }
}
