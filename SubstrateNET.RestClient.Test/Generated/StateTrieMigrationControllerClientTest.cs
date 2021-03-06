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
   using SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration;
   using Ajuna.NetApi.Model.Types.Base;
   
   public class StateTrieMigrationControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask GetTestValue2()
      {
         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask();
         result.ProgressTop = new SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.EnumProgress();
         result.ProgressTop.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.Progress>(), this.GetTestValueBaseVoid());
         result.ProgressChild = new SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.EnumProgress();
         result.ProgressChild.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.Progress>(), this.GetTestValueBaseVoid());
         result.Size = this.GetTestValueU32();
         result.TopItems = this.GetTestValueU32();
         result.ChildItems = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestMigrationProcess()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeMigrationProcess());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetMigrationProcess(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask rpcResult = await rpcClient.GetMigrationProcess();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits>();
         result.Create(this.GetTestValue5());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits GetTestValue5()
      {
         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits();
         result.Size = this.GetTestValueU32();
         result.Item = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAutoLimits()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> mockupValue = this.GetTestValue4();


         Assert.IsTrue(await rpcClient.SubscribeAutoLimits());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAutoLimits(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> rpcResult = await rpcClient.GetAutoLimits();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits GetTestValue7()
      {
         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits();
         result.Size = this.GetTestValueU32();
         result.Item = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSignedMigrationMaxLimits()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits mockupValue = this.GetTestValue7();


         Assert.IsTrue(await rpcClient.SubscribeSignedMigrationMaxLimits());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSignedMigrationMaxLimits(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits rpcResult = await rpcClient.GetSignedMigrationMaxLimits();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
