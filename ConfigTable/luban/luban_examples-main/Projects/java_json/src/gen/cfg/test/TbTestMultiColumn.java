
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


public final class TbTestMultiColumn {
    private final java.util.HashMap<Integer, cfg.test.TestMultiColumn> _dataMap;
    private final java.util.ArrayList<cfg.test.TestMultiColumn> _dataList;
    
    public TbTestMultiColumn(JsonElement _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestMultiColumn>();
        _dataList = new java.util.ArrayList<cfg.test.TestMultiColumn>();
        
        for (com.google.gson.JsonElement _e_ : _buf.getAsJsonArray()) {
            cfg.test.TestMultiColumn _v;
            _v = cfg.test.TestMultiColumn.deserialize(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestMultiColumn> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestMultiColumn> getDataList() { return _dataList; }

    public cfg.test.TestMultiColumn get(int key) { return _dataMap.get(key); }

}
