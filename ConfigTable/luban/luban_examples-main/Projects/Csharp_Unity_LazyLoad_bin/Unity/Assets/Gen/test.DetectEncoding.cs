
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
    public sealed partial class DetectEncoding : Luban.BeanBase
    {
        public DetectEncoding(ByteBuf _buf) 
        {
            Id = _buf.ReadInt();
            Name = _buf.ReadString();
        }

        public static DetectEncoding DeserializeDetectEncoding(ByteBuf _buf)
        {
            return new test.DetectEncoding(_buf);
        }

        public readonly int Id;
        public readonly string Name;
   
        public const int __ID__ = -1154609646;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(Tables tables)
        {
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "}";
        }
    }

}
