using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

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
        GameObject obj;
        if (_prefabDict.ContainsKey(panelName))
        {
            obj = _prefabDict[panelName];
        }
        else
        {
            var prefab = ABManager.Instance.LoadResource<GameObject>("uiprefab",panelName );
            if (prefab == null)
            {
                Debug.LogError("UIManager : No such Panel!");
                return;
            }

            obj = Instantiate(prefab, _uiroot);
            _prefabDict.Add(panelName,obj);
            var canvas = obj.AddComponent<Canvas>();
            // var scaler = obj.AddComponent<CanvasScaler>();
            obj.AddComponent<GraphicRaycaster>();
            canvas.overrideSorting = true;
            string layerName =  "Default";
            if (UILayer.Instance.SortingLayer.ContainsKey(panelName))
            {
                layerName = UILayer.Instance.SortingLayer[panelName];
            }
            canvas.sortingLayerName = layerName;
            canvas.sortingOrder = UILayer.Instance.SortingOrder[panelName];
            //scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            //scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            //scaler.referenceResolution = new Vector2(1920, 1080);
        }
        obj.SetActive(true);

        Type viewType = Type.GetType(panelName.Replace("Panel","View"));
        Type controllerType = Type.GetType(panelName.Replace("Panel", "Controller"));

        var view = obj.GetComponent(viewType) as BaseView ?? obj.AddComponent(viewType) as BaseView;
        var ctl = obj.GetComponent(controllerType) as BaseController ?? obj.AddComponent(controllerType) as BaseController;
        ctl?.BindMvc();
        ctl?.EventReg();
        view?.InitData(args);
        view?.InitView();
    }


    public void HidePanel(string panelName)
    {
        panelName = panelName.Replace("Panel", "");
        if (_prefabDict.ContainsKey(panelName))
        {
            var prefab = _prefabDict[panelName];
            var viewType = Type.GetType(panelName + "View");
            var controllerType = Type.GetType(panelName + "Controller");
            var view = prefab.GetComponent(viewType) as BaseView;
            var ctl = prefab.GetComponent(controllerType) as BaseController;
            view?.DisableView();
            ctl?.EventUnreg();
            prefab.SetActive(false);
        }
    }
    public void ClosePanel(string panelName)
    {
        if (_prefabDict.ContainsKey(panelName))
        {
            var prefab = _prefabDict[panelName];
            var viewType = Type.GetType(panelName + "View");
            var controllerType = Type.GetType(panelName + "Controller");
            var view = prefab.GetComponent(viewType) as BaseView;
            var ctl = prefab.GetComponent(controllerType) as BaseController;
            view?.DisableView();
            ctl?.EventUnreg();
            GameObject.Destroy(prefab);
            _prefabDict.Remove(panelName);
        }
    }
}
