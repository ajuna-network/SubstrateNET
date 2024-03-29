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
    
    
    public sealed class ConvictionVotingStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ConvictionVotingStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ConvictionVoting", "VotingFor"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16>), typeof(SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.EnumVoting)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ConvictionVoting", "ClassLocksFor"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT42)));
        }
        
        /// <summary>
        /// >> VotingForParams
        ///  All voting for a particular voter in a particular voting class. We store the balance for the
        ///  number of votes that we have recorded.
        /// </summary>
        public static string VotingForParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16> key)
        {
            return RequestGenerator.GetStorage("ConvictionVoting", "VotingFor", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VotingFor
        ///  All voting for a particular voter in a particular voting class. We store the balance for the
        ///  number of votes that we have recorded.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.EnumVoting> VotingFor(Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16> key, CancellationToken token)
        {
            string parameters = ConvictionVotingStorage.VotingForParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.EnumVoting>(parameters, token);
        }
        
        /// <summary>
        /// >> ClassLocksForParams
        ///  The voting classes which have a non-zero lock requirement and the lock amounts which they
        ///  require. The actual amount locked on behalf of this pallet should always be the maximum of
        ///  this list.
        /// </summary>
        public static string ClassLocksForParams(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("ConvictionVoting", "ClassLocksFor", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ClassLocksFor
        ///  The voting classes which have a non-zero lock requirement and the lock amounts which they
        ///  require. The actual amount locked on behalf of this pallet should always be the maximum of
        ///  this list.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT42> ClassLocksFor(SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = ConvictionVotingStorage.ClassLocksForParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT42>(parameters, token);
        }
    }
    
    public sealed class ConvictionVotingCalls
    {
        
        /// <summary>
        /// >> vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vote(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> poll_index, SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.vote.EnumAccountVote vote)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(vote.Encode());
            return new Method(47, "ConvictionVoting", 0, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> delegate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Delegate(Ajuna.NetApi.Model.Types.Primitive.U16 @class, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress to, SubstrateNET.NetApi.Generated.Model.pallet_conviction_voting.conviction.EnumConviction conviction, Ajuna.NetApi.Model.Types.Primitive.U128 balance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(to.Encode());
            byteArray.AddRange(conviction.Encode());
            byteArray.AddRange(balance.Encode());
            return new Method(47, "ConvictionVoting", 1, "delegate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> undelegate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Undelegate(Ajuna.NetApi.Model.Types.Primitive.U16 @class)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            return new Method(47, "ConvictionVoting", 2, "undelegate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unlock
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unlock(Ajuna.NetApi.Model.Types.Primitive.U16 @class, SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(target.Encode());
            return new Method(47, "ConvictionVoting", 3, "unlock", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveVote(Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U16> @class, Ajuna.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(47, "ConvictionVoting", 4, "remove_vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_other_vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveOtherVote(SubstrateNET.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target, Ajuna.NetApi.Model.Types.Primitive.U16 @class, Ajuna.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(47, "ConvictionVoting", 5, "remove_other_vote", byteArray.ToArray());
        }
    }
    
    public enum ConvictionVotingErrors
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Poll is not ongoing.
        /// </summary>
        NotOngoing,
        
        /// <summary>
        /// >> NotVoter
        /// The given account did not vote on the poll.
        /// </summary>
        NotVoter,
        
        /// <summary>
        /// >> NoPermission
        /// The actor has no permission to conduct the action.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NoPermissionYet
        /// The actor has no permission to conduct the action right now but will do in the future.
        /// </summary>
        NoPermissionYet,
        
        /// <summary>
        /// >> AlreadyDelegating
        /// The account is already delegating.
        /// </summary>
        AlreadyDelegating,
        
        /// <summary>
        /// >> AlreadyVoting
        /// The account currently has votes attached to it and the operation cannot succeed until
        /// these are removed, either through `unvote` or `reap_vote`.
        /// </summary>
        AlreadyVoting,
        
        /// <summary>
        /// >> InsufficientFunds
        /// Too high a balance was provided that the account cannot afford.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> NotDelegating
        /// The account is not currently delegating.
        /// </summary>
        NotDelegating,
        
        /// <summary>
        /// >> Nonsense
        /// Delegation to oneself makes no sense.
        /// </summary>
        Nonsense,
        
        /// <summary>
        /// >> MaxVotesReached
        /// Maximum number of votes reached.
        /// </summary>
        MaxVotesReached,
        
        /// <summary>
        /// >> ClassNeeded
        /// The class must be supplied since it is not easily determinable from the state.
        /// </summary>
        ClassNeeded,
        
        /// <summary>
        /// >> BadClass
        /// The class ID supplied is invalid.
        /// </summary>
        BadClass,
    }
}
