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
   using SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage;
   
   public class ContractsControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 GetTestValue2()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
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
      public async System.Threading.Tasks.Task TestPristineCode()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 mockupValue = this.GetTestValue2();
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribePristineCode(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPristineCode(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT23 rpcResult = await rpcClient.GetPristineCode(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule GetTestValue5()
      {
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule result;
         result = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule();
         result.InstructionWeightsVersion = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.InstructionWeightsVersion.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Initial = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Initial.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Maximum = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Maximum.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Code = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4();
         result.Code = this.GetTestValue6();
         result.Determinism = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.EnumDeterminism();
         result.Determinism.Create(this.GetTestValueEnum<SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.Determinism>());
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4 GetTestValue6()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT4();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue7()
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
      public async System.Threading.Tasks.Task TestCodeStorage()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule mockupValue = this.GetTestValue5();
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue7();

         Assert.IsTrue(await rpcClient.SubscribeCodeStorage(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCodeStorage(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule rpcResult = await rpcClient.GetCodeStorage(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo GetTestValue9()
      {
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo result;
         result = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo();
         result.Owner = new SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Owner = this.GetTestValue10();
         result.Deposit = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Deposit.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU128().Value));
         result.Refcount = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>();
         result.Refcount.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU64().Value));
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue10()
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
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue11()
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
      public async System.Threading.Tasks.Task TestOwnerInfoOf()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo mockupValue = this.GetTestValue9();
         SubstrateNET.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue11();

         Assert.IsTrue(await rpcClient.SubscribeOwnerInfoOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOwnerInfoOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo rpcResult = await rpcClient.GetOwnerInfoOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNonce()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeNonce());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNonce(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetNonce();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.ContractInfo GetTestValue14()
      {
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.ContractInfo result;
         result = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.ContractInfo();
         result.TrieId = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8();
         result.TrieId = this.GetTestValue15();
         result.CodeHash = new SubstrateNET.NetApi.Generated.Model.primitive_types.H256();
         result.CodeHash = this.GetTestValue16();
         result.StorageBytes = this.GetTestValueU32();
         result.StorageItems = this.GetTestValueU32();
         result.StorageByteDeposit = this.GetTestValueU128();
         result.StorageItemDeposit = this.GetTestValueU128();
         result.StorageBaseDeposit = this.GetTestValueU128();
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 GetTestValue15()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 GetTestValue16()
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
      public async System.Threading.Tasks.Task TestContractInfoOf()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.ContractInfo mockupValue = this.GetTestValue14();
         SubstrateNET.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeContractInfoOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetContractInfoOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.ContractInfo rpcResult = await rpcClient.GetContractInfoOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 GetTestValue19()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract>();
         result.Value.Create(new SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract[] {
                  this.GetTestValue20()});
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract GetTestValue20()
      {
         SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract result;
         result = new SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract();
         result.TrieId = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8();
         result.TrieId = this.GetTestValue21();
         return result;
      }
      public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 GetTestValue21()
      {
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 result;
         result = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDeletionQueue()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 mockupValue = this.GetTestValue19();


         Assert.IsTrue(await rpcClient.SubscribeDeletionQueue());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDeletionQueue(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT24 rpcResult = await rpcClient.GetDeletionQueue();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
