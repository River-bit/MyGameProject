
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;
import com.google.gson.JsonElement;


public final class TbTestSet {
    private final java.util.HashMap<Integer, cfg.test.TestSet> _dataMap;
    private final java.util.ArrayList<cfg.test.TestSet> _dataList;
    
    public TbTestSet(JsonElement _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestSet>();
        _dataList = new java.util.ArrayList<cfg.test.TestSet>();
        
        for (com.google.gson.JsonElement _e_ : _buf.getAsJsonArray()) {
            cfg.test.TestSet _v;
            _v = cfg.test.TestSet.deserialize(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestSet> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestSet> getDataList() { return _dataList; }

    public cfg.test.TestSet get(int key) { return _dataMap.get(key); }

}
