
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TestRow extends AbstractBean {
    public TestRow(ByteBuf _buf) { 
        x = _buf.readInt();
        y = _buf.readBool();
        z = _buf.readString();
        a = cfg.test.Test3.deserialize(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());b = new java.util.ArrayList<Integer>(n);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); b.add(_e);}}
    }

    public static TestRow deserialize(ByteBuf _buf) {
            return new cfg.test.TestRow(_buf);
    }

    public final int x;
    public final boolean y;
    public final String z;
    public final cfg.test.Test3 a;
    public final java.util.ArrayList<Integer> b;

    public static final int __ID__ = -543222164;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + x + ","
        + "(format_field_name __code_style field.name):" + y + ","
        + "(format_field_name __code_style field.name):" + z + ","
        + "(format_field_name __code_style field.name):" + a + ","
        + "(format_field_name __code_style field.name):" + b + ","
        + "}";
    }
}

