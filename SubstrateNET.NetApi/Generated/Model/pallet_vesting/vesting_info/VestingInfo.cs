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


namespace SubstrateNET.NetApi.Generated.Model.pallet_vesting.vesting_info
{
    
    
    /// <summary>
    /// >> 289 - Composite[pallet_vesting.vesting_info.VestingInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class VestingInfo : BaseType
    {
        
        /// <summary>
        /// >> locked
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _locked;
        
        /// <summary>
        /// >> per_block
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _perBlock;
        
        /// <summary>
        /// >> starting_block
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _startingBlock;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Locked
        {
            get
            {
                return this._locked;
            }
            set
            {
                this._locked = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 PerBlock
        {
            get
            {
                return this._perBlock;
            }
            set
            {
                this._perBlock = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 StartingBlock
        {
            get
            {
                return this._startingBlock;
            }
            set
            {
                this._startingBlock = value;
            }
        }
        
        public override string TypeName()
        {
            return "VestingInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Locked.Encode());
            result.AddRange(PerBlock.Encode());
            result.AddRange(StartingBlock.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Locked = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Locked.Decode(byteArray, ref p);
            PerBlock = new Ajuna.NetApi.Model.Types.Primitive.U128();
            PerBlock.Decode(byteArray, ref p);
            StartingBlock = new Ajuna.NetApi.Model.Types.Primitive.U32();
            StartingBlock.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
