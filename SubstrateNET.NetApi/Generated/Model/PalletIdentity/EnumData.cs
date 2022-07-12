//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletIdentity
{
    
    
    public enum Data
    {
        
        None,
        
        Raw0,
        
        Raw1,
        
        Raw2,
        
        Raw3,
        
        Raw4,
        
        Raw5,
        
        Raw6,
        
        Raw7,
        
        Raw8,
        
        Raw9,
        
        Raw10,
        
        Raw11,
        
        Raw12,
        
        Raw13,
        
        Raw14,
        
        Raw15,
        
        Raw16,
        
        Raw17,
        
        Raw18,
        
        Raw19,
        
        Raw20,
        
        Raw21,
        
        Raw22,
        
        Raw23,
        
        Raw24,
        
        Raw25,
        
        Raw26,
        
        Raw27,
        
        Raw28,
        
        Raw29,
        
        Raw30,
        
        Raw31,
        
        Raw32,
        
        BlakeTwo256,
        
        Sha256,
        
        Keccak256,
        
        ShaThree256,
    }
    
    /// <summary>
    /// >> 259 - Variant[pallet_identity.types.Data]
    /// </summary>
    public sealed class EnumData : BaseEnumExt<Data, BaseVoid>
    {
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var enumByte = byteArray[p];
            Value = (Data)System.Enum.Parse(typeof(Data), enumByte.ToString(), true);
            p += 1;
            Value2 = DecodeOneOf(enumByte, byteArray, ref p);
            TypeSize = p - start;
            Bytes = new byte[TypeSize];
            Array.Copy(byteArray, start, base.Bytes, 0, TypeSize);
        }
        
        private Ajuna.NetApi.Model.Types.IType DecodeOneOf(byte value, byte[] byteArray, ref int p)
        {
            IType result;
            if (value == 0) { return new BaseVoid(); };
            if (value == 1) { result = new Arr0U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 2) { result = new Arr1U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 3) { result = new Arr2U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 4) { result = new Arr3U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 5) { result = new Arr4U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 6) { result = new Arr5U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 7) { result = new Arr6U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 8) { result = new Arr7U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 9) { result = new Arr8U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 10) { result = new Arr9U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 11) { result = new Arr10U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 12) { result = new Arr11U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 13) { result = new Arr12U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 15) { result = new Arr14U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 16) { result = new Arr15U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 17) { result = new Arr16U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 18) { result = new Arr17U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 19) { result = new Arr18U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 20) { result = new Arr19U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 21) { result = new Arr20U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 22) { result = new Arr21U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 23) { result = new Arr22U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 24) { result = new Arr23U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 25) { result = new Arr24U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 26) { result = new Arr25U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 27) { result = new Arr26U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 28) { result = new Arr27U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 29) { result = new Arr28U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 30) { result = new Arr29U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 31) { result = new Arr30U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 32) { result = new Arr31U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 33) { result = new Arr32U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 34) { result = new Arr32U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 35) { result = new Arr32U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 36) { result = new Arr32U8(); result.Decode(byteArray, ref p); return result; };
            if (value == 37) { result = new Arr32U8(); result.Decode(byteArray, ref p); return result; };
            throw new NotImplementedException("Invalid leading byte, please check source");;
        }
    }
}
