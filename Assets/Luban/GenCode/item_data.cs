
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
public sealed partial class item_data : Luban.BeanBase
{
    public item_data(JSONNode _buf) 
    {
        { if(!_buf["index"].IsNumber) { throw new SerializationException(); }  Index = _buf["index"]; }
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["itemType"].IsNumber) { throw new SerializationException(); }  ItemType = (item.EType)_buf["itemType"].AsInt; }
        { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
        { if(!_buf["equipType"].IsNumber) { throw new SerializationException(); }  EquipType = (item.EEquipType)_buf["equipType"].AsInt; }
    }

    public static item_data Deserializeitem_data(JSONNode _buf)
    {
        return new item_data(_buf);
    }

    public readonly int Index;
    public readonly int Id;
    public readonly item.EType ItemType;
    public readonly string Name;
    public readonly item.EEquipType EquipType;
   
    public const int __ID__ = -2141642410;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "index:" + Index + ","
        + "id:" + Id + ","
        + "itemType:" + ItemType + ","
        + "name:" + Name + ","
        + "equipType:" + EquipType + ","
        + "}";
    }
}

}
