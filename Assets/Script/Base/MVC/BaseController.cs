using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    protected BaseModel _model;
    protected BaseView _view;

    private void Awake()
    {
        InitController(transform);
    }

    public void InitController(Transform trans)
    {
        
    }

    public abstract void BindMvc();

    /// <summary>
    /// 使用 BaseModel的EventRegister的方法
    /// </summary>
    public virtual void EventReg()
    {
        _model.EventRegister("UpdateView",_view.UpdateView);
    }

    /// <summary>
    /// 使用 BaseModel的EventUnregister的方法
    /// </summary>
    public virtual void EventUnreg()
    {
        _model.EventUnregister("UpdateView");
    }
}
