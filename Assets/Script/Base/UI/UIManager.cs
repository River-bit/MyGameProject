using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class UIManager : Common.SigletonMonoBase<UIManager>
{
    private Canvas _rootCanvas;
    private Transform _uiroot;
    private Dictionary<string, GameObject> _prefabDict = new Dictionary<string, GameObject>();

    public void Awake()
    {
        _rootCanvas = FindObjectOfType<Canvas>();
        _uiroot = _rootCanvas.transform;
    }

    public void ShowPanel(string panelName,params object[] args)
    {
        GameObject prefab;
        if (_prefabDict.ContainsKey(panelName))
        {
            prefab = _prefabDict[panelName];
        }
        else
        {
            prefab = ABManager.Instance.LoadResource<GameObject>("uiprefab",panelName);
            _prefabDict.Add(panelName,prefab);
        }
        prefab.SetActive(true);

        Type viewType = Type.GetType(panelName+"View");
        Type controllerType = Type.GetType(panelName+"Controller");

        var view = prefab.GetComponent(viewType);
        var ctl = prefab.GetComponent(controllerType);
        if (view == null)
        {
            prefab.AddComponent(viewType);
        }
        if (ctl == null)
        {
            prefab.AddComponent(controllerType);
        }

        MethodInfo InitData = viewType.GetMethod("InitData", new Type[] {typeof(object[])});
        MethodInfo InitView = viewType.GetMethod("InitView", new Type[] {});
        InitData?.Invoke(view,args);
        InitView?.Invoke(view,null);
    }

    public void HidePanel(string panelName)
    {
        if (_prefabDict.ContainsKey(panelName))
        {
            var prefab = _prefabDict[panelName];
            var viewType = Type.GetType(panelName + "View");
            var view = prefab.GetComponent(viewType);
            MethodInfo DisableView = viewType.GetMethod("DisableView", new Type[] {});
            DisableView?.Invoke(view,null);
            prefab.SetActive(false);
        }
    }

    public void ClosePanel(string panelName)
    {
        if (_prefabDict.ContainsKey(panelName))
        {
            var prefab = _prefabDict[panelName];
            var viewType = Type.GetType(panelName + "View");
            var view = prefab.GetComponent(viewType);
            MethodInfo DisableView = viewType.GetMethod("DisableView", new Type[] {});
            DisableView?.Invoke(view,null);
            GameObject.Destroy(prefab);
            _prefabDict.Remove(panelName);
        }
    }
}
