//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Storage
{
    
    
    public sealed class TransactionPaymentStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TransactionPaymentStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionPayment", "NextFeeMultiplier"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TransactionPayment", "StorageVersion"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.pallet_transaction_payment.EnumReleases)));
        }
        
        /// <summary>
        /// >> NextFeeMultiplierParams
        /// </summary>
        public static string NextFeeMultiplierParams()
        {
            return RequestGenerator.GetStorage("TransactionPayment", "NextFeeMultiplier", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextFeeMultiplier
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128> NextFeeMultiplier(CancellationToken token)
        {
            string parameters = TransactionPaymentStorage.NextFeeMultiplierParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>(parameters, token);
        }
        
        /// <summary>
        /// >> StorageVersionParams
        /// </summary>
        public static string StorageVersionParams()
        {
            return RequestGenerator.GetStorage("TransactionPayment", "StorageVersion", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StorageVersion
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.pallet_transaction_payment.EnumReleases> StorageVersion(CancellationToken token)
        {
            string parameters = TransactionPaymentStorage.StorageVersionParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.pallet_transaction_payment.EnumReleases>(parameters, token);
        }
    }
    
    public sealed class TransactionPaymentCalls
    {
    }
}
