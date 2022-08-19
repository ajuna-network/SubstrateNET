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
   using Ajuna.NetApi.Model.Types.Base;
   using SubstrateNET.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using SubstrateNET.NetApi.Generated.Model.node_runtime;
   
   public interface ISessionControllerClient
   {
      Task<BaseVec<AccountId32>> GetValidators();
      Task<bool> SubscribeValidators();
      Task<U32> GetCurrentIndex();
      Task<bool> SubscribeCurrentIndex();
      Task<Bool> GetQueuedChanged();
      Task<bool> SubscribeQueuedChanged();
      Task<BaseVec<BaseTuple<AccountId32, SessionKeys>>> GetQueuedKeys();
      Task<bool> SubscribeQueuedKeys();
      Task<BaseVec<U32>> GetDisabledValidators();
      Task<bool> SubscribeDisabledValidators();
      Task<SessionKeys> GetNextKeys(AccountId32 key);
      Task<bool> SubscribeNextKeys(AccountId32 key);
      Task<AccountId32> GetKeyOwner(BaseTuple<KeyTypeId, BaseVec<U8>> key);
      Task<bool> SubscribeKeyOwner(BaseTuple<KeyTypeId, BaseVec<U8>> key);
   }
}
