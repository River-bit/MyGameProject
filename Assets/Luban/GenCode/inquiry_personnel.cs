
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg
{
public sealed partial class inquiry_personnel : Luban.BeanBase
{
    public inquiry_personnel(JSONNode _buf) 
    {
        { if(!_buf["index"].IsString) { throw new SerializationException(); }  Index = _buf["index"]; }
        { if(!_buf["ID"].IsNumber) { throw new SerializationException(); }  ID = _buf["ID"]; }
        { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
        { if(!_buf["case"].IsNumber) { throw new SerializationException(); }  Case = _buf["case"]; }
    }

    public static inquiry_personnel Deserializeinquiry_personnel(JSONNode _buf)
    {
        return new inquiry_personnel(_buf);
    }

    public readonly string Index;
    public readonly int ID;
    /// <summary>
    /// 名字
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 对应案件
    /// </summary>
    public readonly int Case;
   
    public const int __ID__ = 1637747112;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "index:" + Index + ","
        + "ID:" + ID + ","
        + "name:" + Name + ","
        + "case:" + Case + ","
        + "}";
    }
}

}