using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

abstract class UIBase : MonoBehaviour{
    protected Canvas canvas;
    protected CanvasScaler scaler;
    protected GraphicRaycaster raycaster;
    private void Awake()
    {
        canvas = GetComponent<Canvas> ();
        if (canvas == null){
            canvas = transform.AddComponent<Canvas>();
        }
        scaler = GetComponent<CanvasScaler> ();
        if (canvas == null){
            scaler = transform.AddComponent<CanvasScaler>();
        }
        raycaster = GetComponent<GraphicRaycaster> ();
        if (canvas == null){
            raycaster = transform.AddComponent<GraphicRaycaster>();
        }
    }
    /// <summary>
    /// 初始化组件
    /// </summary>
    abstract public void InitComponent();
    virtual public void AddEvent(){}
    virtual public void RemoveEvent(){}
    virtual public void EnablePanel(params object[] param) {}
    virtual public void EnablePanel() { }
    virtual public void DisablePanel(){}
    virtual public void Reg() { }
    virtual public void UnReg() { }
    virtual public void Leave() { }
    virtual public void Back() { }
}
