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
    
    
    public sealed class TreasuryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TreasuryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "ProposalCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Proposals"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.pallet_treasury.Proposal)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Approvals"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22)));
        }
        
        /// <summary>
        /// >> ProposalCountParams
        ///  Number of proposals that have been made.
        /// </summary>
        public static string ProposalCountParams()
        {
            return RequestGenerator.GetStorage("Treasury", "ProposalCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> ProposalCount(CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ProposalsParams
        ///  Proposals that have been made.
        /// </summary>
        public static string ProposalsParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Treasury", "Proposals", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.pallet_treasury.Proposal> Proposals(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.pallet_treasury.Proposal>(parameters, token);
        }
        
        /// <summary>
        /// >> ApprovalsParams
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public static string ApprovalsParams()
        {
            return RequestGenerator.GetStorage("Treasury", "Approvals", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22> Approvals(CancellationToken token)
        {
            string parameters = TreasuryStorage.ApprovalsParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT22>(parameters, token);
        }
    }
    
    public sealed class TreasuryCalls
    {
        
        /// <summary>
        /// >> propose_spend
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ProposeSpend(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress beneficiary)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(beneficiary.Encode());
            return new Method(18, "Treasury", 0, "propose_spend", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reject_proposal
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RejectProposal(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(18, "Treasury", 1, "reject_proposal", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_proposal
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ApproveProposal(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(18, "Treasury", 2, "approve_proposal", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> spend
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Spend(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> amount, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress beneficiary)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(beneficiary.Encode());
            return new Method(18, "Treasury", 3, "spend", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_approval
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveApproval(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(18, "Treasury", 4, "remove_approval", byteArray.ToArray());
        }
    }
    
    public enum TreasuryErrors
    {
        
        /// <summary>
        /// >> InsufficientProposersBalance
        /// Proposer's balance is too low.
        /// </summary>
        InsufficientProposersBalance,
        
        /// <summary>
        /// >> InvalidIndex
        /// No proposal or bounty at that index.
        /// </summary>
        InvalidIndex,
        
        /// <summary>
        /// >> TooManyApprovals
        /// Too many approvals in the queue.
        /// </summary>
        TooManyApprovals,
        
        /// <summary>
        /// >> InsufficientPermission
        /// The spend origin is valid but the amount it is allowed to spend is lower than the
        /// amount to be spent.
        /// </summary>
        InsufficientPermission,
        
        /// <summary>
        /// >> ProposalNotApproved
        /// Proposal has not been approved.
        /// </summary>
        ProposalNotApproved,
    }
}
