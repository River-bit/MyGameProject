using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using Common.UI;
using UnityEngine;
using UnityEngine.UI;

static class UITools
{
    static public LoopScrollView AddLoopScrollView(Transform uibase, string scrollPath, string contentPath, string itemPath, int itemCnt, int scrollListLength, Action<int, GameObject> callBack = null, float pad = 10)
    {
        Transform scroll = TransformHelper.GetCompnent<Transform>(uibase, scrollPath);
        Transform content = TransformHelper.GetCompnent<Transform>(uibase, contentPath);
        Transform item = TransformHelper.GetCompnent<Transform>(uibase, itemPath);
        item.gameObject.SetActive(false);
        if (scroll == null || content == null || item == null)
        {
            Debug.LogError("Common.UI.MyUICompnentCreator : 路径错误，找不到组件");
            return null;
        }

        scroll.gameObject.AddComponent<RectMask2D>();
        scroll.gameObject.AddComponent<UnityEngine.UI.Image>().color = new Color(0,0,0,0);
        var loopList = scroll.gameObject.AddComponent<LoopScrollView>();
        loopList.AddScrollView(item, content, itemCnt, scrollListLength, callBack, pad);
        return loopList;
    }

    static public MyToggleGroup AddToggleGroup(Transform parent,Transform itemBase)
    {
        var ret = parent.gameObject.AddComponent<MyToggleGroup>();
        ret.SetItemBase(itemBase);
        return ret;
    }
}
