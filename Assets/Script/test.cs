using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Awake()
    {
        // UIManager.Instance.ShowPanel("CharaMakePanel",0);
        var obj = ResourcesManager.Instance.Load<GameObject>("Prefab/UI/TimePanel");
    }
}
