using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

class ConfigReader:Common.SigletonBase<ConfigReader>{
    //TODO
    static private string gameConfDir = "Assets/Luban/GenerateDatas/json";
    static public cfg.Tables _allTables;
    public cfg.Tables Tables {
        get {
            if (_allTables == null){
                _allTables = new cfg.Tables(file => JSON.Parse(File.ReadAllText($"{gameConfDir}/{file}.json")));
            }
            return _allTables;
        }
    }
    public ConfigReader() { }
}
