
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public abstract class DemoDynamic extends AbstractBean {
    public DemoDynamic(ByteBuf _buf) { 
        x1 = _buf.readInt();
    }

    public static DemoDynamic deserialize(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.test.DemoD2.__ID__: return new cfg.test.DemoD2(_buf);
            case cfg.test.DemoE1.__ID__: return new cfg.test.DemoE1(_buf);
            case cfg.test.login.RoleInfo.__ID__: return new cfg.test.login.RoleInfo(_buf);
            case cfg.test.DemoD5.__ID__: return new cfg.test.DemoD5(_buf);
            default: throw new SerializationException();
        }
    }

    public final int x1;


    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + x1 + ","
        + "}";
    }
}

