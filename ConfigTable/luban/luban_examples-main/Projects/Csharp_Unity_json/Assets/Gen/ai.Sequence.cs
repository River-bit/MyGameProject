
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.ai
{
public sealed partial class Sequence : ai.ComposeNode
{
    public Sequence(JSONNode _buf)  : base(_buf) 
    {
        { var __json0 = _buf["children"]; if(!__json0.IsArray) { throw new SerializationException(); } Children = new System.Collections.Generic.List<ai.FlowNode>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.FlowNode __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.FlowNode.DeserializeFlowNode(__e0);  }  Children.Add(__v0); }   }
    }

    public static Sequence DeserializeSequence(JSONNode _buf)
    {
        return new ai.Sequence(_buf);
    }

    public readonly System.Collections.Generic.List<ai.FlowNode> Children;
   
    public const int __ID__ = -1789006105;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        foreach (var _e in Children) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "children:" + Luban.StringUtil.CollectionToString(Children) + ","
        + "}";
    }
}

}
