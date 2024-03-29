//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things;
   using SubstrateNET.NetApi.Generated.Model.pallet_staking;
   using SubstrateNET.NetApi.Generated.Model.pallet_staking.slashing;
   
   public interface IStakingControllerClient
   {
      Task<U32> GetValidatorCount();
      Task<bool> SubscribeValidatorCount();
      Task<U32> GetMinimumValidatorCount();
      Task<bool> SubscribeMinimumValidatorCount();
      Task<BaseVec<AccountId32>> GetInvulnerables();
      Task<bool> SubscribeInvulnerables();
      Task<AccountId32> GetBonded(AccountId32 key);
      Task<bool> SubscribeBonded(AccountId32 key);
      Task<U128> GetMinNominatorBond();
      Task<bool> SubscribeMinNominatorBond();
      Task<U128> GetMinValidatorBond();
      Task<bool> SubscribeMinValidatorBond();
      Task<Perbill> GetMinCommission();
      Task<bool> SubscribeMinCommission();
      Task<StakingLedger> GetLedger(AccountId32 key);
      Task<bool> SubscribeLedger(AccountId32 key);
      Task<EnumRewardDestination> GetPayee(AccountId32 key);
      Task<bool> SubscribePayee(AccountId32 key);
      Task<ValidatorPrefs> GetValidators(AccountId32 key);
      Task<bool> SubscribeValidators(AccountId32 key);
      Task<U32> GetCounterForValidators();
      Task<bool> SubscribeCounterForValidators();
      Task<U32> GetMaxValidatorsCount();
      Task<bool> SubscribeMaxValidatorsCount();
      Task<Nominations> GetNominators(AccountId32 key);
      Task<bool> SubscribeNominators(AccountId32 key);
      Task<U32> GetCounterForNominators();
      Task<bool> SubscribeCounterForNominators();
      Task<U32> GetMaxNominatorsCount();
      Task<bool> SubscribeMaxNominatorsCount();
      Task<U32> GetCurrentEra();
      Task<bool> SubscribeCurrentEra();
      Task<ActiveEraInfo> GetActiveEra();
      Task<bool> SubscribeActiveEra();
      Task<U32> GetErasStartSessionIndex(U32 key);
      Task<bool> SubscribeErasStartSessionIndex(U32 key);
      Task<Exposure> GetErasStakers(BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeErasStakers(BaseTuple<U32, AccountId32> key);
      Task<Exposure> GetErasStakersClipped(BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeErasStakersClipped(BaseTuple<U32, AccountId32> key);
      Task<ValidatorPrefs> GetErasValidatorPrefs(BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeErasValidatorPrefs(BaseTuple<U32, AccountId32> key);
      Task<U128> GetErasValidatorReward(U32 key);
      Task<bool> SubscribeErasValidatorReward(U32 key);
      Task<EraRewardPoints> GetErasRewardPoints(U32 key);
      Task<bool> SubscribeErasRewardPoints(U32 key);
      Task<U128> GetErasTotalStake(U32 key);
      Task<bool> SubscribeErasTotalStake(U32 key);
      Task<EnumForcing> GetForceEra();
      Task<bool> SubscribeForceEra();
      Task<Perbill> GetSlashRewardFraction();
      Task<bool> SubscribeSlashRewardFraction();
      Task<U128> GetCanceledSlashPayout();
      Task<bool> SubscribeCanceledSlashPayout();
      Task<BaseVec<UnappliedSlash>> GetUnappliedSlashes(U32 key);
      Task<bool> SubscribeUnappliedSlashes(U32 key);
      Task<BaseVec<BaseTuple<U32, U32>>> GetBondedEras();
      Task<bool> SubscribeBondedEras();
      Task<BaseTuple<Perbill, U128>> GetValidatorSlashInEra(BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeValidatorSlashInEra(BaseTuple<U32, AccountId32> key);
      Task<U128> GetNominatorSlashInEra(BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeNominatorSlashInEra(BaseTuple<U32, AccountId32> key);
      Task<SlashingSpans> GetSlashingSpans(AccountId32 key);
      Task<bool> SubscribeSlashingSpans(AccountId32 key);
      Task<SpanRecord> GetSpanSlash(BaseTuple<AccountId32, U32> key);
      Task<bool> SubscribeSpanSlash(BaseTuple<AccountId32, U32> key);
      Task<U32> GetCurrentPlannedSession();
      Task<bool> SubscribeCurrentPlannedSession();
      Task<BaseVec<BaseTuple<U32, Bool>>> GetOffendingValidators();
      Task<bool> SubscribeOffendingValidators();
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
      Task<Percent> GetChillThreshold();
      Task<bool> SubscribeChillThreshold();
   }
}
