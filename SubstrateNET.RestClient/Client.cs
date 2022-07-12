//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using SubstrateNET.RestClient.Generated.Interfaces;
   using SubstrateNET.RestClient.Generated.Clients;
   
   public sealed class Client
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IAllianceControllerClient AllianceControllerClient;
      public IAllianceMotionControllerClient AllianceMotionControllerClient;
      public IAssetsControllerClient AssetsControllerClient;
      public IAuthorityDiscoveryControllerClient AuthorityDiscoveryControllerClient;
      public IAuthorshipControllerClient AuthorshipControllerClient;
      public IBabeControllerClient BabeControllerClient;
      public IBagsListControllerClient BagsListControllerClient;
      public IBalancesControllerClient BalancesControllerClient;
      public IBountiesControllerClient BountiesControllerClient;
      public IChildBountiesControllerClient ChildBountiesControllerClient;
      public IContractsControllerClient ContractsControllerClient;
      public IConvictionVotingControllerClient ConvictionVotingControllerClient;
      public ICouncilControllerClient CouncilControllerClient;
      public IDemocracyControllerClient DemocracyControllerClient;
      public IElectionProviderMultiPhaseControllerClient ElectionProviderMultiPhaseControllerClient;
      public IElectionsControllerClient ElectionsControllerClient;
      public IGiltControllerClient GiltControllerClient;
      public IGrandpaControllerClient GrandpaControllerClient;
      public IIdentityControllerClient IdentityControllerClient;
      public IImOnlineControllerClient ImOnlineControllerClient;
      public IIndicesControllerClient IndicesControllerClient;
      public ILotteryControllerClient LotteryControllerClient;
      public IMmrControllerClient MmrControllerClient;
      public IMultisigControllerClient MultisigControllerClient;
      public INominationPoolsControllerClient NominationPoolsControllerClient;
      public IOffencesControllerClient OffencesControllerClient;
      public IPreimageControllerClient PreimageControllerClient;
      public IProxyControllerClient ProxyControllerClient;
      public IRandomnessCollectiveFlipControllerClient RandomnessCollectiveFlipControllerClient;
      public IRankedCollectiveControllerClient RankedCollectiveControllerClient;
      public IRankedPollsControllerClient RankedPollsControllerClient;
      public IRecoveryControllerClient RecoveryControllerClient;
      public IReferendaControllerClient ReferendaControllerClient;
      public ISchedulerControllerClient SchedulerControllerClient;
      public ISessionControllerClient SessionControllerClient;
      public ISocietyControllerClient SocietyControllerClient;
      public IStakingControllerClient StakingControllerClient;
      public IStateTrieMigrationControllerClient StateTrieMigrationControllerClient;
      public ISudoControllerClient SudoControllerClient;
      public ISystemControllerClient SystemControllerClient;
      public ITechnicalCommitteeControllerClient TechnicalCommitteeControllerClient;
      public ITechnicalMembershipControllerClient TechnicalMembershipControllerClient;
      public ITimestampControllerClient TimestampControllerClient;
      public ITipsControllerClient TipsControllerClient;
      public ITransactionPaymentControllerClient TransactionPaymentControllerClient;
      public ITransactionStorageControllerClient TransactionStorageControllerClient;
      public ITreasuryControllerClient TreasuryControllerClient;
      public IUniquesControllerClient UniquesControllerClient;
      public IVestingControllerClient VestingControllerClient;
      public IWhitelistControllerClient WhitelistControllerClient;
      public Client(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
         AllianceControllerClient = new AllianceControllerClient(_httpClient, _subscriptionClient);
         AllianceMotionControllerClient = new AllianceMotionControllerClient(_httpClient, _subscriptionClient);
         AssetsControllerClient = new AssetsControllerClient(_httpClient, _subscriptionClient);
         AuthorityDiscoveryControllerClient = new AuthorityDiscoveryControllerClient(_httpClient, _subscriptionClient);
         AuthorshipControllerClient = new AuthorshipControllerClient(_httpClient, _subscriptionClient);
         BabeControllerClient = new BabeControllerClient(_httpClient, _subscriptionClient);
         BagsListControllerClient = new BagsListControllerClient(_httpClient, _subscriptionClient);
         BalancesControllerClient = new BalancesControllerClient(_httpClient, _subscriptionClient);
         BountiesControllerClient = new BountiesControllerClient(_httpClient, _subscriptionClient);
         ChildBountiesControllerClient = new ChildBountiesControllerClient(_httpClient, _subscriptionClient);
         ContractsControllerClient = new ContractsControllerClient(_httpClient, _subscriptionClient);
         ConvictionVotingControllerClient = new ConvictionVotingControllerClient(_httpClient, _subscriptionClient);
         CouncilControllerClient = new CouncilControllerClient(_httpClient, _subscriptionClient);
         DemocracyControllerClient = new DemocracyControllerClient(_httpClient, _subscriptionClient);
         ElectionProviderMultiPhaseControllerClient = new ElectionProviderMultiPhaseControllerClient(_httpClient, _subscriptionClient);
         ElectionsControllerClient = new ElectionsControllerClient(_httpClient, _subscriptionClient);
         GiltControllerClient = new GiltControllerClient(_httpClient, _subscriptionClient);
         GrandpaControllerClient = new GrandpaControllerClient(_httpClient, _subscriptionClient);
         IdentityControllerClient = new IdentityControllerClient(_httpClient, _subscriptionClient);
         ImOnlineControllerClient = new ImOnlineControllerClient(_httpClient, _subscriptionClient);
         IndicesControllerClient = new IndicesControllerClient(_httpClient, _subscriptionClient);
         LotteryControllerClient = new LotteryControllerClient(_httpClient, _subscriptionClient);
         MmrControllerClient = new MmrControllerClient(_httpClient, _subscriptionClient);
         MultisigControllerClient = new MultisigControllerClient(_httpClient, _subscriptionClient);
         NominationPoolsControllerClient = new NominationPoolsControllerClient(_httpClient, _subscriptionClient);
         OffencesControllerClient = new OffencesControllerClient(_httpClient, _subscriptionClient);
         PreimageControllerClient = new PreimageControllerClient(_httpClient, _subscriptionClient);
         ProxyControllerClient = new ProxyControllerClient(_httpClient, _subscriptionClient);
         RandomnessCollectiveFlipControllerClient = new RandomnessCollectiveFlipControllerClient(_httpClient, _subscriptionClient);
         RankedCollectiveControllerClient = new RankedCollectiveControllerClient(_httpClient, _subscriptionClient);
         RankedPollsControllerClient = new RankedPollsControllerClient(_httpClient, _subscriptionClient);
         RecoveryControllerClient = new RecoveryControllerClient(_httpClient, _subscriptionClient);
         ReferendaControllerClient = new ReferendaControllerClient(_httpClient, _subscriptionClient);
         SchedulerControllerClient = new SchedulerControllerClient(_httpClient, _subscriptionClient);
         SessionControllerClient = new SessionControllerClient(_httpClient, _subscriptionClient);
         SocietyControllerClient = new SocietyControllerClient(_httpClient, _subscriptionClient);
         StakingControllerClient = new StakingControllerClient(_httpClient, _subscriptionClient);
         StateTrieMigrationControllerClient = new StateTrieMigrationControllerClient(_httpClient, _subscriptionClient);
         SudoControllerClient = new SudoControllerClient(_httpClient, _subscriptionClient);
         SystemControllerClient = new SystemControllerClient(_httpClient, _subscriptionClient);
         TechnicalCommitteeControllerClient = new TechnicalCommitteeControllerClient(_httpClient, _subscriptionClient);
         TechnicalMembershipControllerClient = new TechnicalMembershipControllerClient(_httpClient, _subscriptionClient);
         TimestampControllerClient = new TimestampControllerClient(_httpClient, _subscriptionClient);
         TipsControllerClient = new TipsControllerClient(_httpClient, _subscriptionClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerClient(_httpClient, _subscriptionClient);
         TransactionStorageControllerClient = new TransactionStorageControllerClient(_httpClient, _subscriptionClient);
         TreasuryControllerClient = new TreasuryControllerClient(_httpClient, _subscriptionClient);
         UniquesControllerClient = new UniquesControllerClient(_httpClient, _subscriptionClient);
         VestingControllerClient = new VestingControllerClient(_httpClient, _subscriptionClient);
         WhitelistControllerClient = new WhitelistControllerClient(_httpClient, _subscriptionClient);
      }
   }
}
