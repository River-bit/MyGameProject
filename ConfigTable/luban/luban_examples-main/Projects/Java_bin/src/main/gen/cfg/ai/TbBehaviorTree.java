
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class TbBehaviorTree {
    private final java.util.HashMap<Integer, cfg.ai.BehaviorTree> _dataMap;
    private final java.util.ArrayList<cfg.ai.BehaviorTree> _dataList;
    
    public TbBehaviorTree(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.ai.BehaviorTree>();
        _dataList = new java.util.ArrayList<cfg.ai.BehaviorTree>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.ai.BehaviorTree _v;
            _v = cfg.ai.BehaviorTree.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.ai.BehaviorTree> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.ai.BehaviorTree> getDataList() { return _dataList; }

    public cfg.ai.BehaviorTree get(int key) { return _dataMap.get(key); }

}
