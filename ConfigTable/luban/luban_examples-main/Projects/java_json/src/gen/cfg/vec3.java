
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class vec3 extends AbstractBean {
    public vec3(JsonObject _buf) { 
        x = _buf.get("x").getAsFloat();
        y = _buf.get("y").getAsFloat();
        z = _buf.get("z").getAsFloat();
    }

    public static vec3 deserialize(JsonObject _buf) {
            return new cfg.vec3(_buf);
    }

    public final float x;
    public final float y;
    public final float z;

    public static final int __ID__ = 3615519;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + x + ","
        + "(format_field_name __code_style field.name):" + y + ","
        + "(format_field_name __code_style field.name):" + z + ","
        + "}";
    }
}

