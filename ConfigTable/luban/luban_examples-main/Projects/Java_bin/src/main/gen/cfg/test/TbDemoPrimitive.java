
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbDemoPrimitive {
    private final java.util.HashMap<Integer, cfg.test.DemoPrimitiveTypesTable> _dataMap;
    private final java.util.ArrayList<cfg.test.DemoPrimitiveTypesTable> _dataList;
    
    public TbDemoPrimitive(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DemoPrimitiveTypesTable>();
        _dataList = new java.util.ArrayList<cfg.test.DemoPrimitiveTypesTable>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.DemoPrimitiveTypesTable _v;
            _v = cfg.test.DemoPrimitiveTypesTable.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.x4, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DemoPrimitiveTypesTable> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DemoPrimitiveTypesTable> getDataList() { return _dataList; }

    public cfg.test.DemoPrimitiveTypesTable get(int key) { return _dataMap.get(key); }

}
