using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    private BaseModel _model;
    private BaseView _view;

    public BaseController(BaseModel model,BaseView view)
    {
        _model = model;
        _view = view;
    }

    /// <summary>
    /// 使用 BaseModel的EventRegister的方法
    /// </summary>
    protected void Reg()
    {
        _model.EventRegister("UpdateView",_view.UpdateView);
    }

    /// <summary>
    /// 使用 BaseModel的EventUnregister的方法
    /// </summary>
    protected void Unreg()
    {
        _model.EventUnregister("UpdateView");
    }
}
