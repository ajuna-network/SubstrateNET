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
   using SubstrateNET.NetApi.Generated.Model.SpRuntime;
   using SubstrateNET.NetApi.Generated.Model.PalletContracts;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IContractsControllerClient
   {
      Task<BoundedVecT17> GetPristineCode(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SubscribePristineCode(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<PrefabWasmModule> GetCodeStorage(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SubscribeCodeStorage(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<OwnerInfo> GetOwnerInfoOf(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SubscribeOwnerInfoOf(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<U64> GetNonce();
      Task<bool> SubscribeNonce();
      Task<RawContractInfo> GetContractInfoOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribeContractInfoOf(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<BoundedVecT20> GetDeletionQueue();
      Task<bool> SubscribeDeletionQueue();
   }
}
