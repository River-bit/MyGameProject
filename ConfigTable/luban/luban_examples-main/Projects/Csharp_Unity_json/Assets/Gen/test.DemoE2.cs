
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
public partial struct DemoE2
{
    public DemoE2(JSONNode _buf) 
    {
        { var _j = _buf["y1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  Y1 = _j; } } else { Y1 = null; } }
        { if(!_buf["y2"].IsBoolean) { throw new SerializationException(); }  Y2 = _buf["y2"]; }
    }

    public static DemoE2 DeserializeDemoE2(JSONNode _buf)
    {
        return new test.DemoE2(_buf);
    }

    public readonly int? Y1;
    public readonly bool Y2;
   

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "y1:" + Y1 + ","
        + "y2:" + Y2 + ","
        + "}";
    }
}

}
