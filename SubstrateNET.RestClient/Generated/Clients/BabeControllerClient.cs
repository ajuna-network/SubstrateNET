//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   using SubstrateNET.NetApi.Generated.Model.SpConsensusSlots;
   using SubstrateNET.NetApi.Generated.Model.Base;
   using SubstrateNET.NetApi.Generated.Model.SpConsensusBabe;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.RestClient.Generated.Interfaces;
   
   public sealed class BabeControllerClient : BaseClient, IBabeControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BabeControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U64> GetEpochIndex()
      {
         return await SendRequestAsync<U64>(_httpClient, "babe/epochindex");
      }
      public async Task<bool> SubscribeEpochIndex()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.EpochIndex");
      }
      public async Task<WeakBoundedVecT1> GetAuthorities()
      {
         return await SendRequestAsync<WeakBoundedVecT1>(_httpClient, "babe/authorities");
      }
      public async Task<bool> SubscribeAuthorities()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.Authorities");
      }
      public async Task<Slot> GetGenesisSlot()
      {
         return await SendRequestAsync<Slot>(_httpClient, "babe/genesisslot");
      }
      public async Task<bool> SubscribeGenesisSlot()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.GenesisSlot");
      }
      public async Task<Slot> GetCurrentSlot()
      {
         return await SendRequestAsync<Slot>(_httpClient, "babe/currentslot");
      }
      public async Task<bool> SubscribeCurrentSlot()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.CurrentSlot");
      }
      public async Task<Arr32U8> GetRandomness()
      {
         return await SendRequestAsync<Arr32U8>(_httpClient, "babe/randomness");
      }
      public async Task<bool> SubscribeRandomness()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.Randomness");
      }
      public async Task<EnumNextConfigDescriptor> GetPendingEpochConfigChange()
      {
         return await SendRequestAsync<EnumNextConfigDescriptor>(_httpClient, "babe/pendingepochconfigchange");
      }
      public async Task<bool> SubscribePendingEpochConfigChange()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.PendingEpochConfigChange");
      }
      public async Task<Arr32U8> GetNextRandomness()
      {
         return await SendRequestAsync<Arr32U8>(_httpClient, "babe/nextrandomness");
      }
      public async Task<bool> SubscribeNextRandomness()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.NextRandomness");
      }
      public async Task<WeakBoundedVecT1> GetNextAuthorities()
      {
         return await SendRequestAsync<WeakBoundedVecT1>(_httpClient, "babe/nextauthorities");
      }
      public async Task<bool> SubscribeNextAuthorities()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.NextAuthorities");
      }
      public async Task<U32> GetSegmentIndex()
      {
         return await SendRequestAsync<U32>(_httpClient, "babe/segmentindex");
      }
      public async Task<bool> SubscribeSegmentIndex()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.SegmentIndex");
      }
      public async Task<BoundedVecT5> GetUnderConstruction(U32 key)
      {
         return await SendRequestAsync<BoundedVecT5>(_httpClient, "babe/underconstruction", SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.UnderConstructionParams(key));
      }
      public async Task<bool> SubscribeUnderConstruction(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Babe.UnderConstruction", SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.UnderConstructionParams(key));
      }
      public async Task<BaseOpt<EnumPreDigest>> GetInitialized()
      {
         return await SendRequestAsync<BaseOpt<EnumPreDigest>>(_httpClient, "babe/initialized");
      }
      public async Task<bool> SubscribeInitialized()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.Initialized");
      }
      public async Task<BaseOpt<Arr32U8>> GetAuthorVrfRandomness()
      {
         return await SendRequestAsync<BaseOpt<Arr32U8>>(_httpClient, "babe/authorvrfrandomness");
      }
      public async Task<bool> SubscribeAuthorVrfRandomness()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.AuthorVrfRandomness");
      }
      public async Task<BaseTuple<U32, U32>> GetEpochStart()
      {
         return await SendRequestAsync<BaseTuple<U32, U32>>(_httpClient, "babe/epochstart");
      }
      public async Task<bool> SubscribeEpochStart()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.EpochStart");
      }
      public async Task<U32> GetLateness()
      {
         return await SendRequestAsync<U32>(_httpClient, "babe/lateness");
      }
      public async Task<bool> SubscribeLateness()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.Lateness");
      }
      public async Task<BabeEpochConfiguration> GetEpochConfig()
      {
         return await SendRequestAsync<BabeEpochConfiguration>(_httpClient, "babe/epochconfig");
      }
      public async Task<bool> SubscribeEpochConfig()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.EpochConfig");
      }
      public async Task<BabeEpochConfiguration> GetNextEpochConfig()
      {
         return await SendRequestAsync<BabeEpochConfiguration>(_httpClient, "babe/nextepochconfig");
      }
      public async Task<bool> SubscribeNextEpochConfig()
      {
         return await _subscriptionClient.SubscribeAsync("Babe.NextEpochConfig");
      }
   }
}
