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


namespace SubstrateNET.NetApi.Generated.Model.FrameSystem
{
    
    
    /// <summary>
    /// >> 632 - Composite[frame_system.extensions.check_weight.CheckWeight]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class CheckWeight : BaseType
    {
        
        public override string TypeName()
        {
            return "CheckWeight";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TypeSize = p - start;
        }
    }
}
