
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class MultiRowRecord : Luban.BeanBase
{
    public MultiRowRecord(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);OneRows = new System.Collections.Generic.List<test.MultiRowType1>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType1 _e0;  _e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); OneRows.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows1 = new System.Collections.Generic.List<test.MultiRowType1>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType1 _e0;  _e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows1.Add(_e0);}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows2 = new test.MultiRowType1[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { test.MultiRowType1 __e0;__e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows2[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows4 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); test.MultiRowType2 _v0;  _v0 = test.MultiRowType2.DeserializeMultiRowType2(_buf);     MultiRows4.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows5 = new System.Collections.Generic.List<test.MultiRowType3>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType3 _e0;  _e0 = test.MultiRowType3.DeserializeMultiRowType3(_buf); MultiRows5.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows6 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); test.MultiRowType2 _v0;  _v0 = test.MultiRowType2.DeserializeMultiRowType2(_buf);     MultiRows6.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows7 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     MultiRows7.Add(_k0, _v0);}}
    }

    public static MultiRowRecord DeserializeMultiRowRecord(ByteBuf _buf)
    {
        return new test.MultiRowRecord(_buf);
    }

    public readonly int Id;
    public readonly string Name;
    public readonly System.Collections.Generic.List<test.MultiRowType1> OneRows;
    public readonly System.Collections.Generic.List<test.MultiRowType1> MultiRows1;
    public readonly test.MultiRowType1[] MultiRows2;
    public readonly System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows4;
    public readonly System.Collections.Generic.List<test.MultiRowType3> MultiRows5;
    public readonly System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows6;
    public readonly System.Collections.Generic.Dictionary<int, int> MultiRows7;
   
    public const int __ID__ = -501249394;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        foreach (var _e in OneRows) { _e?.ResolveRef(tables); }
        foreach (var _e in MultiRows1) { _e?.ResolveRef(tables); }
        foreach (var _e in MultiRows2) { _e?.ResolveRef(tables); }
        foreach (var _e in MultiRows4.Values) { _e?.ResolveRef(tables); }
        foreach (var _e in MultiRows5) { _e?.ResolveRef(tables); }
        foreach (var _e in MultiRows6.Values) { _e?.ResolveRef(tables); }
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "oneRows:" + Luban.StringUtil.CollectionToString(OneRows) + ","
        + "multiRows1:" + Luban.StringUtil.CollectionToString(MultiRows1) + ","
        + "multiRows2:" + Luban.StringUtil.CollectionToString(MultiRows2) + ","
        + "multiRows4:" + Luban.StringUtil.CollectionToString(MultiRows4) + ","
        + "multiRows5:" + Luban.StringUtil.CollectionToString(MultiRows5) + ","
        + "multiRows6:" + Luban.StringUtil.CollectionToString(MultiRows6) + ","
        + "multiRows7:" + Luban.StringUtil.CollectionToString(MultiRows7) + ","
        + "}";
    }
}

}
