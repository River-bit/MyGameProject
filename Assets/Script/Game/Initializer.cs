using System.Collections;
using System.Collections.Generic;
using Procedure;
using UnityEngine;

public class Initializer:Common.SigletonBase<Initializer>
{
    public void Init()
    {
        InitFsmManager();
    }
    public void InitFsmManager()
    {
        ProcedureManager.Instance.Init();
    }
}
