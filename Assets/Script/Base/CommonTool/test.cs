using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

class test : MonoBehaviour{
    public Transform _item;
    public Transform _parent;
    private void Awake()
    {
        Common.UI.MyUICompnentCreator.AddLoopScrollView(transform, null, "Content", "Button", 6, 12, TestFunc,10);
    }
    private void TestFunc(int index, GameObject item)
    {
        print("I am index: " + index);
        Common.TransformHelper.GetCompnent<TextMeshProUGUI>(item.transform, "Text (TMP)").text = index.ToString();
    }
}
