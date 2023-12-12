using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Awake()
    {
        print("Test");
        UIManager.Instance.ShowPanel("CharaMakePanel",0);
    }
}
