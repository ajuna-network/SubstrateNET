//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.NetApi.Generated.Model.SpConsensusSlots;
   using SubstrateNET.NetApi.Generated.Model.Base;
   using SubstrateNET.NetApi.Generated.Model.SpConsensusBabe;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BabeControllerMockupClient : MockupBaseClient, IBabeControllerMockupClient
   {
      private HttpClient _httpClient;
      public BabeControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetEpochIndex(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/EpochIndex", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.EpochIndexParams());
      }
      public async Task<bool> SetAuthorities(WeakBoundedVecT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/Authorities", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.AuthoritiesParams());
      }
      public async Task<bool> SetGenesisSlot(Slot value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/GenesisSlot", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.GenesisSlotParams());
      }
      public async Task<bool> SetCurrentSlot(Slot value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/CurrentSlot", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.CurrentSlotParams());
      }
      public async Task<bool> SetRandomness(Arr32U8 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/Randomness", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.RandomnessParams());
      }
      public async Task<bool> SetPendingEpochConfigChange(EnumNextConfigDescriptor value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/PendingEpochConfigChange", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.PendingEpochConfigChangeParams());
      }
      public async Task<bool> SetNextRandomness(Arr32U8 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/NextRandomness", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.NextRandomnessParams());
      }
      public async Task<bool> SetNextAuthorities(WeakBoundedVecT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/NextAuthorities", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.NextAuthoritiesParams());
      }
      public async Task<bool> SetSegmentIndex(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/SegmentIndex", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.SegmentIndexParams());
      }
      public async Task<bool> SetUnderConstruction(BoundedVecT8 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/UnderConstruction", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.UnderConstructionParams(key));
      }
      public async Task<bool> SetInitialized(BaseOpt<EnumPreDigest> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/Initialized", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.InitializedParams());
      }
      public async Task<bool> SetAuthorVrfRandomness(BaseOpt<Arr32U8> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/AuthorVrfRandomness", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.AuthorVrfRandomnessParams());
      }
      public async Task<bool> SetEpochStart(BaseTuple<U32, U32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/EpochStart", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.EpochStartParams());
      }
      public async Task<bool> SetLateness(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/Lateness", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.LatenessParams());
      }
      public async Task<bool> SetEpochConfig(BabeEpochConfiguration value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/EpochConfig", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.EpochConfigParams());
      }
      public async Task<bool> SetNextEpochConfig(BabeEpochConfiguration value)
      {
         return await SendMockupRequestAsync(_httpClient, "Babe/NextEpochConfig", value.Encode(), SubstrateNET.NetApi.Generated.Model.PalletBabe.BabeStorage.NextEpochConfigParams());
      }
   }
}
