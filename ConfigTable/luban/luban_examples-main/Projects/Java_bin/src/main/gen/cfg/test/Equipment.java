
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class Equipment extends cfg.test.ItemBase {
    public Equipment(ByteBuf _buf) { 
        super(_buf);
        attr = _buf.readInt();
        value = _buf.readInt();
    }

    public static Equipment deserialize(ByteBuf _buf) {
            return new cfg.test.Equipment(_buf);
    }

    public final int attr;
    public final int value;

    public static final int __ID__ = -76837102;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + name + ","
        + "(format_field_name __code_style field.name):" + desc + ","
        + "(format_field_name __code_style field.name):" + attr + ","
        + "(format_field_name __code_style field.name):" + value + ","
        + "}";
    }
}

