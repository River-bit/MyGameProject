
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


public final class TbTestGlobal {
    private final cfg.test.TestGlobal _data;

    public final cfg.test.TestGlobal data() { return _data; }

    public TbTestGlobal(JsonElement _buf) {
        int n = _buf.getAsJsonArray().size();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = cfg.test.TestGlobal.deserialize(_buf.getAsJsonArray().get(0).getAsJsonObject().getAsJsonObject());
    }


     public int getUnlockEquip() { return _data.unlockEquip; }
     public int getUnlockHero() { return _data.unlockHero; }

}
