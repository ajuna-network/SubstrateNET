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
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.PalletBounties;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public class BountiesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestBountyCount()
      {
         // Construct new Mockup client to test with.
         BountiesControllerMockupClient mockupClient = new BountiesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BountiesControllerClient rpcClient = new BountiesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeBountyCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBountyCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetBountyCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.PalletBounties.Bounty GetTestValue3()
      {
         SubstrateNET.NetApi.Generated.Model.PalletBounties.Bounty result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletBounties.Bounty();
         result.Proposer = new SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32();
         result.Proposer = this.GetTestValue4();
         result.Value = this.GetTestValueU128();
         result.Fee = this.GetTestValueU128();
         result.CuratorDeposit = this.GetTestValueU128();
         result.Bond = this.GetTestValueU128();
         result.Status = new SubstrateNET.NetApi.Generated.Model.PalletBounties.EnumBountyStatus();
         result.Status.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.PalletBounties.BountyStatus>(), this.GetTestValueBaseVoid());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue4()
      {
         SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 result;
         result = new SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32();
         result.Value = new SubstrateNET.NetApi.Generated.Model.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestBounties()
      {
         // Construct new Mockup client to test with.
         BountiesControllerMockupClient mockupClient = new BountiesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BountiesControllerClient rpcClient = new BountiesControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.PalletBounties.Bounty mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeBounties(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBounties(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.PalletBounties.Bounty rpcResult = await rpcClient.GetBounties(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT21 GetTestValue6()
      {
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT21 result;
         result = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT21();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestBountyDescriptions()
      {
         // Construct new Mockup client to test with.
         BountiesControllerMockupClient mockupClient = new BountiesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BountiesControllerClient rpcClient = new BountiesControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT21 mockupValue = this.GetTestValue6();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeBountyDescriptions(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBountyDescriptions(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT21 rpcResult = await rpcClient.GetBountyDescriptions(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT11 GetTestValue8()
      {
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT11 result;
         result = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT11();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U32[] {
                  this.GetTestValueU32()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestBountyApprovals()
      {
         // Construct new Mockup client to test with.
         BountiesControllerMockupClient mockupClient = new BountiesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BountiesControllerClient rpcClient = new BountiesControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT11 mockupValue = this.GetTestValue8();


         Assert.IsTrue(await rpcClient.SubscribeBountyApprovals());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBountyApprovals(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT11 rpcResult = await rpcClient.GetBountyApprovals();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
