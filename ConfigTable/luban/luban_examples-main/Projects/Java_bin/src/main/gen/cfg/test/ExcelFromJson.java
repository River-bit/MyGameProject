
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class ExcelFromJson extends AbstractBean {
    public ExcelFromJson(ByteBuf _buf) { 
        x4 = _buf.readInt();
        x1 = _buf.readBool();
        x5 = _buf.readLong();
        x6 = _buf.readFloat();
        s1 = _buf.readString();
        s2 = _buf.readString();
        t1 = _buf.readLong();
        x12 = cfg.test.DemoType1.deserialize(_buf);
        x13 = _buf.readInt();
        x14 = cfg.test.DemoDynamic.deserialize(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());k1 = new int[n];for(int i = 0 ; i < n ; i++) { int _e;_e = _buf.readInt(); k1[i] = _e;}}
        {int n = Math.min(_buf.readSize(), _buf.size());k8 = new java.util.HashMap<Integer, Integer>(n * 3 / 2);for(int i = 0 ; i < n ; i++) { Integer _k;  _k = _buf.readInt(); Integer _v;  _v = _buf.readInt();     k8.put(_k, _v);}}
        {int n = Math.min(_buf.readSize(), _buf.size());k9 = new java.util.ArrayList<cfg.test.DemoE2>(n);for(int i = 0 ; i < n ; i++) { cfg.test.DemoE2 _e;  _e = cfg.test.DemoE2.deserialize(_buf); k9.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());k15 = new cfg.test.DemoDynamic[n];for(int i = 0 ; i < n ; i++) { cfg.test.DemoDynamic _e;_e = cfg.test.DemoDynamic.deserialize(_buf); k15[i] = _e;}}
    }

    public static ExcelFromJson deserialize(ByteBuf _buf) {
            return new cfg.test.ExcelFromJson(_buf);
    }

    public final int x4;
    public final boolean x1;
    public final long x5;
    public final float x6;
    public final String s1;
    public final String s2;
    public final long t1;
    public final cfg.test.DemoType1 x12;
    public final int x13;
    public final cfg.test.DemoDynamic x14;
    public final int[] k1;
    public final java.util.HashMap<Integer, Integer> k8;
    public final java.util.ArrayList<cfg.test.DemoE2> k9;
    public final cfg.test.DemoDynamic[] k15;

    public static final int __ID__ = -1485706483;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + x4 + ","
        + "(format_field_name __code_style field.name):" + x1 + ","
        + "(format_field_name __code_style field.name):" + x5 + ","
        + "(format_field_name __code_style field.name):" + x6 + ","
        + "(format_field_name __code_style field.name):" + s1 + ","
        + "(format_field_name __code_style field.name):" + s2 + ","
        + "(format_field_name __code_style field.name):" + t1 + ","
        + "(format_field_name __code_style field.name):" + x12 + ","
        + "(format_field_name __code_style field.name):" + x13 + ","
        + "(format_field_name __code_style field.name):" + x14 + ","
        + "(format_field_name __code_style field.name):" + k1 + ","
        + "(format_field_name __code_style field.name):" + k8 + ","
        + "(format_field_name __code_style field.name):" + k9 + ","
        + "(format_field_name __code_style field.name):" + k15 + ","
        + "}";
    }
}

