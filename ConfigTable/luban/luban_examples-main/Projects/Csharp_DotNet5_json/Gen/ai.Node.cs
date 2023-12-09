
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.ai
{
public abstract partial class Node : Luban.BeanBase
{
    public Node(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        NodeName = _buf.GetProperty("node_name").GetString();
    }

    public static Node DeserializeNode(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "UeSetDefaultFocus": return new ai.UeSetDefaultFocus(_buf);
            case "ExecuteTimeStatistic": return new ai.ExecuteTimeStatistic(_buf);
            case "ChooseTarget": return new ai.ChooseTarget(_buf);
            case "KeepFaceTarget": return new ai.KeepFaceTarget(_buf);
            case "GetOwnerPlayer": return new ai.GetOwnerPlayer(_buf);
            case "UpdateDailyBehaviorProps": return new ai.UpdateDailyBehaviorProps(_buf);
            case "UeLoop": return new ai.UeLoop(_buf);
            case "UeCooldown": return new ai.UeCooldown(_buf);
            case "UeTimeLimit": return new ai.UeTimeLimit(_buf);
            case "UeBlackboard": return new ai.UeBlackboard(_buf);
            case "UeForceSuccess": return new ai.UeForceSuccess(_buf);
            case "IsAtLocation": return new ai.IsAtLocation(_buf);
            case "DistanceLessThan": return new ai.DistanceLessThan(_buf);
            case "Sequence": return new ai.Sequence(_buf);
            case "Selector": return new ai.Selector(_buf);
            case "SimpleParallel": return new ai.SimpleParallel(_buf);
            case "UeWait": return new ai.UeWait(_buf);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_buf);
            case "MoveToTarget": return new ai.MoveToTarget(_buf);
            case "ChooseSkill": return new ai.ChooseSkill(_buf);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_buf);
            case "MoveToLocation": return new ai.MoveToLocation(_buf);
            case "DebugPrint": return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly int Id;
    public readonly string NodeName;
   

    public virtual void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "}";
    }
}

}
