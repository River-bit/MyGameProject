
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;

namespace editor.cfg.test
{

public sealed class TestMap :  Luban.EditorBeanBase 
{
    public TestMap()
    {
            x1 = new System.Collections.Generic.Dictionary<int,int>();
            x2 = new System.Collections.Generic.Dictionary<long,int>();
            x3 = new System.Collections.Generic.Dictionary<string,int>();
            x4 = new System.Collections.Generic.Dictionary<test.DemoEnum,int>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x1 = new System.Collections.Generic.Dictionary<int, int>(); foreach(JSONNode __e in _fieldJson.Children) { int __k;  if(!__e[0].IsNumber) { throw new SerializationException(); }  __k = __e[0]; int __v;  if(!__e[1].IsNumber) { throw new SerializationException(); }  __v = __e[1];  x1.Add(__k, __v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x2 = new System.Collections.Generic.Dictionary<long, int>(); foreach(JSONNode __e in _fieldJson.Children) { long __k;  if(!__e[0].IsNumber) { throw new SerializationException(); }  __k = __e[0]; int __v;  if(!__e[1].IsNumber) { throw new SerializationException(); }  __v = __e[1];  x2.Add(__k, __v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x3 = new System.Collections.Generic.Dictionary<string, int>(); foreach(JSONNode __e in _fieldJson.Children) { string __k;  if(!__e[0].IsString) { throw new SerializationException(); }  __k = __e[0]; int __v;  if(!__e[1].IsNumber) { throw new SerializationException(); }  __v = __e[1];  x3.Add(__k, __v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x4 = new System.Collections.Generic.Dictionary<test.DemoEnum, int>(); foreach(JSONNode __e in _fieldJson.Children) { test.DemoEnum __k;  if(__e[0].IsString) { __k = (test.DemoEnum)System.Enum.Parse(typeof(test.DemoEnum), __e[0]); } else if(__e[0].IsNumber) { __k = (test.DemoEnum)(int)__e[0]; } else { throw new SerializationException(); }   int __v;  if(!__e[1].IsNumber) { throw new SerializationException(); }  __v = __e[1];  x4.Add(__k, __v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (x1 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in x1) { var __entry = new JSONArray(); __cjson[null] = __entry; __entry["null"] = new JSONNumber(_e.Key); __entry["null"] = new JSONNumber(_e.Value); } _json["x1"] = __cjson; }
        }
        {

            if (x2 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in x2) { var __entry = new JSONArray(); __cjson[null] = __entry; __entry["null"] = new JSONNumber(_e.Key); __entry["null"] = new JSONNumber(_e.Value); } _json["x2"] = __cjson; }
        }
        {

            if (x3 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in x3) { var __entry = new JSONArray(); __cjson[null] = __entry; __entry["null"] = new JSONString(_e.Key); __entry["null"] = new JSONNumber(_e.Value); } _json["x3"] = __cjson; }
        }
        {

            if (x4 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in x4) { var __entry = new JSONArray(); __cjson[null] = __entry; __entry["null"] = new JSONNumber((int)_e.Key); __entry["null"] = new JSONNumber(_e.Value); } _json["x4"] = __cjson; }
        }
    }

    public static TestMap LoadJsonTestMap(SimpleJSON.JSONNode _json)
    {
        TestMap obj = new test.TestMap();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestMap(TestMap _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;

    public System.Collections.Generic.Dictionary<int, int> x1;

    public System.Collections.Generic.Dictionary<long, int> x2;

    public System.Collections.Generic.Dictionary<string, int> x3;

    public System.Collections.Generic.Dictionary<test.DemoEnum, int> x4;

}

}
