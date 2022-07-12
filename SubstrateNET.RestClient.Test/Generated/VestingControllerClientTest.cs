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
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.NetApi.Generated.Model.PalletVesting;
   
   public class VestingControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT26 GetTestValue2()
      {
         SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT26 result;
         result = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT26();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.PalletVesting.VestingInfo>();
         result.Value.Create(new SubstrateNET.NetApi.Generated.Model.PalletVesting.VestingInfo[] {
                  this.GetTestValue3()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.PalletVesting.VestingInfo GetTestValue3()
      {
         SubstrateNET.NetApi.Generated.Model.PalletVesting.VestingInfo result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletVesting.VestingInfo();
         result.Locked = this.GetTestValueU128();
         result.PerBlock = this.GetTestValueU128();
         result.StartingBlock = this.GetTestValueU32();
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
      public async System.Threading.Tasks.Task TestVesting()
      {
         // Construct new Mockup client to test with.
         VestingControllerMockupClient mockupClient = new VestingControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         VestingControllerClient rpcClient = new VestingControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT26 mockupValue = this.GetTestValue2();
         SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 mockupKey = this.GetTestValue4();

         Assert.IsTrue(await rpcClient.SubscribeVesting(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetVesting(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT26 rpcResult = await rpcClient.GetVesting(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.PalletVesting.EnumReleases GetTestValue6()
      {
         SubstrateNET.NetApi.Generated.Model.PalletVesting.EnumReleases result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletVesting.EnumReleases();
         result.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.PalletVesting.Releases>());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestStorageVersion()
      {
         // Construct new Mockup client to test with.
         VestingControllerMockupClient mockupClient = new VestingControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         VestingControllerClient rpcClient = new VestingControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.PalletVesting.EnumReleases mockupValue = this.GetTestValue6();


         Assert.IsTrue(await rpcClient.SubscribeStorageVersion());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetStorageVersion(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.PalletVesting.EnumReleases rpcResult = await rpcClient.GetStorageVersion();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
