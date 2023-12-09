using System;
using System.Collections;
using System.Collections.Generic;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using UnityEngine;

public class CharaMaker : Common.SigletonBase<CharaMaker>
{
    private Dictionary<int, GameObject> _charaObjDict = new Dictionary<int, GameObject>();

    public GameObject GetCharaGameObject(int index)
    {
        return _charaObjDict.ContainsKey(index) ? _charaObjDict[index] : null;
    }

    public GameObject CreateCharaGameObject(int index,CharaSkinInfo skinInfo)
    {
        return null;
    }
}
