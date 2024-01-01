using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILayer : Common.SigletonBase<UILayer>
{
    public Dictionary<string, string> SortingLayer = new Dictionary<string, string>()
    {
    };
    public Dictionary<string, int> SortingOrder = new Dictionary<string, int>()
    {
        {"CharaMakePanel",1},
    };
    
}
