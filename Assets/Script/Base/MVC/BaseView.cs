using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class BaseView : MonoBehaviour
{
    private void Awake()
    {
        InitUI(transform);
    }

    protected Dictionary<string, Transform> UIs = new Dictionary<string, Transform>();
    public abstract void UpdateView(params object[] args);
    public abstract void InitData(params object[] args);
    public abstract void InitView();
    public abstract void DisableView();
    public void InitUI(Transform parent)
    {
        if (parent == null)
        {
            return;
        }
        var childrenCnt = parent.childCount;
        for (int i = 0; i < childrenCnt; i++)
        {
            Transform trans = parent.transform.GetChild(i);
            if (!UIs.ContainsKey(trans.name))
            {
                UIs.Add(trans.name,transform);
                InitUI(trans);
            }
        }
    }
}
