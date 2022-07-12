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
   using SubstrateNET.NetApi.Generated.Model.PalletPreimage;
   using SubstrateNET.NetApi.Generated.Model.FrameSupport;
   
   public class PreimageControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus GetTestValue2()
      {
         SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus result;
         result = new SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus();
         result.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.PalletPreimage.RequestStatus>(), this.GetTestValue3());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> GetTestValue3()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>();
         result.Create(this.GetTestValue4());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Create(this.GetTestValue5(), this.GetTestValueU128());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue5()
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
      public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 GetTestValue6()
      {
         SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 result;
         result = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
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
      public async System.Threading.Tasks.Task TestStatusFor()
      {
         // Construct new Mockup client to test with.
         PreimageControllerMockupClient mockupClient = new PreimageControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         PreimageControllerClient rpcClient = new PreimageControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus mockupValue = this.GetTestValue2();
         SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeStatusFor(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetStatusFor(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus rpcResult = await rpcClient.GetStatusFor(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT22 GetTestValue8()
      {
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT22 result;
         result = new SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT22();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 GetTestValue9()
      {
         SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 result;
         result = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
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
      public async System.Threading.Tasks.Task TestPreimageFor()
      {
         // Construct new Mockup client to test with.
         PreimageControllerMockupClient mockupClient = new PreimageControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         PreimageControllerClient rpcClient = new PreimageControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT22 mockupValue = this.GetTestValue8();
         SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 mockupKey = this.GetTestValue9();

         Assert.IsTrue(await rpcClient.SubscribePreimageFor(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPreimageFor(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.FrameSupport.BoundedVecT22 rpcResult = await rpcClient.GetPreimageFor(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
