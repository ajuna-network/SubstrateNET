//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstrateNET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using SubstrateNET.RestClient.Mockup.Generated.Clients;
   using SubstrateNET.RestClient.Generated.Clients;
   using SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec;
   using SubstrateNET.NetApi.Generated.Model.kitchensink_runtime;
   using SubstrateNET.NetApi.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   
   public class CouncilControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19 GetTestValue2()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.primitive_types.H256>();
         result.Value.Create(new SubstrateNET.NetApi.Generated.Model.primitive_types.H256[] {
                  this.GetTestValue3()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue3()
      {
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 result;
         result = new SubstrateNET.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestProposals()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeProposals());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetProposals(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19 rpcResult = await rpcClient.GetProposals();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall GetTestValue5()
      {
         SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall result;
         result = new SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall();
         result.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.RuntimeCall>(), this.GetTestValue6());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.frame_system.pallet.EnumCall GetTestValue6()
      {
         SubstrateNET.NetApi.Generated.Model.frame_system.pallet.EnumCall result;
         result = new SubstrateNET.NetApi.Generated.Model.frame_system.pallet.EnumCall();
         result.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.frame_system.pallet.Call>(), this.GetTestValue7());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue7()
      {
         SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue8()
      {
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 result;
         result = new SubstrateNET.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestProposalOf()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall mockupValue = this.GetTestValue5();
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue8();

         Assert.IsTrue(await rpcClient.SubscribeProposalOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetProposalOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.kitchensink_runtime.EnumRuntimeCall rpcResult = await rpcClient.GetProposalOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.pallet_collective.Votes GetTestValue10()
      {
         SubstrateNET.NetApi.Generated.Model.pallet_collective.Votes result;
         result = new SubstrateNET.NetApi.Generated.Model.pallet_collective.Votes();
         result.Index = this.GetTestValueU32();
         result.Threshold = this.GetTestValueU32();
         result.Ayes = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
         result.Ayes.Create(new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue11()});
         result.Nays = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
         result.Nays.Create(new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue12()});
         result.End = this.GetTestValueU32();
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue11()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue12()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue13()
      {
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 result;
         result = new SubstrateNET.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestVoting()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.pallet_collective.Votes mockupValue = this.GetTestValue10();
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue13();

         Assert.IsTrue(await rpcClient.SubscribeVoting(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetVoting(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.pallet_collective.Votes rpcResult = await rpcClient.GetVoting(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestProposalCount()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeProposalCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetProposalCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetProposalCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> GetTestValue16()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
         result.Create(new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue17()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue17()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestMembers()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> mockupValue = this.GetTestValue16();


         Assert.IsTrue(await rpcClient.SubscribeMembers());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetMembers(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32> rpcResult = await rpcClient.GetMembers();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue19()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new SubstrateNET.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPrime()
      {
         // Construct new Mockup client to test with.
         CouncilControllerMockupClient mockupClient = new CouncilControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CouncilControllerClient rpcClient = new CouncilControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupValue = this.GetTestValue19();


         Assert.IsTrue(await rpcClient.SubscribePrime());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPrime(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 rpcResult = await rpcClient.GetPrime();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
