
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public sealed partial class CompositeJsonTable3 : Luban.BeanBase
{
    public CompositeJsonTable3(JSONNode _buf) 
    {
        { if(!_buf["a"].IsNumber) { throw new SerializationException(); }  A = _buf["a"]; }
        { if(!_buf["b"].IsNumber) { throw new SerializationException(); }  B = _buf["b"]; }
    }

    public static CompositeJsonTable3 DeserializeCompositeJsonTable3(JSONNode _buf)
    {
        return new test.CompositeJsonTable3(_buf);
    }

    public readonly int A;
    public readonly int B;
   
    public const int __ID__ = 1566207896;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "a:" + A + ","
        + "b:" + B + ","
        + "}";
    }
}

}
