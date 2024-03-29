//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.pallet_contracts.storage
{
    
    
    /// <summary>
    /// >> 491 - Composite[pallet_contracts.storage.ContractInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ContractInfo : BaseType
    {
        
        /// <summary>
        /// >> trie_id
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 _trieId;
        
        /// <summary>
        /// >> code_hash
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.primitive_types.H256 _codeHash;
        
        /// <summary>
        /// >> storage_bytes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _storageBytes;
        
        /// <summary>
        /// >> storage_items
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _storageItems;
        
        /// <summary>
        /// >> storage_byte_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _storageByteDeposit;
        
        /// <summary>
        /// >> storage_item_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _storageItemDeposit;
        
        /// <summary>
        /// >> storage_base_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _storageBaseDeposit;
        
        public SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8 TrieId
        {
            get
            {
                return this._trieId;
            }
            set
            {
                this._trieId = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.primitive_types.H256 CodeHash
        {
            get
            {
                return this._codeHash;
            }
            set
            {
                this._codeHash = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 StorageBytes
        {
            get
            {
                return this._storageBytes;
            }
            set
            {
                this._storageBytes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 StorageItems
        {
            get
            {
                return this._storageItems;
            }
            set
            {
                this._storageItems = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 StorageByteDeposit
        {
            get
            {
                return this._storageByteDeposit;
            }
            set
            {
                this._storageByteDeposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 StorageItemDeposit
        {
            get
            {
                return this._storageItemDeposit;
            }
            set
            {
                this._storageItemDeposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 StorageBaseDeposit
        {
            get
            {
                return this._storageBaseDeposit;
            }
            set
            {
                this._storageBaseDeposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "ContractInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TrieId.Encode());
            result.AddRange(CodeHash.Encode());
            result.AddRange(StorageBytes.Encode());
            result.AddRange(StorageItems.Encode());
            result.AddRange(StorageByteDeposit.Encode());
            result.AddRange(StorageItemDeposit.Encode());
            result.AddRange(StorageBaseDeposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TrieId = new SubstrateNET.NetApi.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT8();
            TrieId.Decode(byteArray, ref p);
            CodeHash = new SubstrateNET.NetApi.Generated.Model.primitive_types.H256();
            CodeHash.Decode(byteArray, ref p);
            StorageBytes = new Ajuna.NetApi.Model.Types.Primitive.U32();
            StorageBytes.Decode(byteArray, ref p);
            StorageItems = new Ajuna.NetApi.Model.Types.Primitive.U32();
            StorageItems.Decode(byteArray, ref p);
            StorageByteDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            StorageByteDeposit.Decode(byteArray, ref p);
            StorageItemDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            StorageItemDeposit.Decode(byteArray, ref p);
            StorageBaseDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            StorageBaseDeposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
