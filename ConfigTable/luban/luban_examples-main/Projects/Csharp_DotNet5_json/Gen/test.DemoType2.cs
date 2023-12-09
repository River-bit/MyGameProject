
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.test
{
public sealed partial class DemoType2 : Luban.BeanBase
{
    public DemoType2(JsonElement _buf) 
    {
        X4 = _buf.GetProperty("x4").GetInt32();
        X1 = _buf.GetProperty("x1").GetBoolean();
        X2 = _buf.GetProperty("x2").GetByte();
        X3 = _buf.GetProperty("x3").GetInt16();
        X5 = _buf.GetProperty("x5").GetInt64();
        X6 = _buf.GetProperty("x6").GetSingle();
        X7 = _buf.GetProperty("x7").GetDouble();
        X80 = _buf.GetProperty("x8_0").GetInt16();
        X8 = _buf.GetProperty("x8").GetInt32();
        X9 = _buf.GetProperty("x9").GetInt64();
        X10 = _buf.GetProperty("x10").GetString();
        X12 = test.DemoType1.DeserializeDemoType1(_buf.GetProperty("x12"));
        X13 = (test.DemoEnum)_buf.GetProperty("x13").GetInt32();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf.GetProperty("x14"));
        S1 = _buf.GetProperty("s1").GetString();
        T1 = _buf.GetProperty("t1").GetInt64();
        { var __json0 = _buf.GetProperty("k1"); int _n0 = __json0.GetArrayLength(); K1 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K1[__index0++] = __v0; }   }
        { var __json0 = _buf.GetProperty("k2"); K2 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K2.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("k5"); K5 = new System.Collections.Generic.HashSet<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K5.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  K8.Add(_k0, _v0); }   }
        { var __json0 = _buf.GetProperty("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoE2 __v0;  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  K9.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("k15"); int _n0 = __json0.GetArrayLength(); K15 = new test.DemoDynamic[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoDynamic __v0;  __v0 = test.DemoDynamic.DeserializeDemoDynamic(__e0);  K15[__index0++] = __v0; }   }
    }

    public static DemoType2 DeserializeDemoType2(JsonElement _buf)
    {
        return new test.DemoType2(_buf);
    }

    public readonly int X4;
    public readonly bool X1;
    public readonly byte X2;
    public readonly short X3;
    public readonly long X5;
    public readonly float X6;
    public readonly double X7;
    public readonly short X80;
    public readonly int X8;
    public readonly long X9;
    public readonly string X10;
    public readonly test.DemoType1 X12;
    public readonly test.DemoEnum X13;
    public readonly test.DemoDynamic X14;
    public readonly string S1;
    public readonly long T1;
    public readonly int[] K1;
    public readonly System.Collections.Generic.List<int> K2;
    public readonly System.Collections.Generic.HashSet<int> K5;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly test.DemoDynamic[] K15;
   
    public const int __ID__ = -367048295;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        
        
        
        
        
        X12?.ResolveRef(tables);
        
        X14?.ResolveRef(tables);
        
        
        
        
        
        
        
        foreach (var _e in K15) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "x4:" + X4 + ","
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "x7:" + X7 + ","
        + "x80:" + X80 + ","
        + "x8:" + X8 + ","
        + "x9:" + X9 + ","
        + "x10:" + X10 + ","
        + "x12:" + X12 + ","
        + "x13:" + X13 + ","
        + "x14:" + X14 + ","
        + "s1:" + S1 + ","
        + "t1:" + T1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(K2) + ","
        + "k5:" + Luban.StringUtil.CollectionToString(K5) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "k15:" + Luban.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
}

}
