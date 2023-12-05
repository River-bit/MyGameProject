using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

class UIManager : Common.SigletonBase<UIManager>{
    private Dictionary<string,GameObject> panelCache = new Dictionary<string, GameObject>();
    private GameObject uiParent = null;
    public UIBase ShowPanel(string panelName,int sortOrder = 50,params object[] parms){
        if (uiParent == null)
        {
            uiParent = new GameObject("UIParent");
        }
        GameObject panel;
        Canvas canvas;
        CanvasScaler scaler;
        if (panelCache.ContainsKey(panelName))
        {
            panel = panelCache[panelName];
            canvas = panel.GetComponent<Canvas>();
            scaler = panel.GetComponent<CanvasScaler>();
        }
        else
        {
#if UNITY_EDITOR
            GameObject panelPrefab = ABManager.Instance.LoadResource<GameObject>("uiprefab", panelName);
#else
            GameObject panelPrefab = ABManager.Instance.LoadResource<GameObject>("uiprefab", panelName);
#endif
            if (panelPrefab == null)
            {
                Debug.LogError("Prefab don't find : " + panelName);
                return null;
            }
            panel = GameObject.Instantiate(panelPrefab, uiParent.transform);
            canvas = panel.AddComponent<Canvas>();
            scaler = panel.AddComponent<CanvasScaler>();
            panel.AddComponent<GraphicRaycaster>();
            panelCache.Add(panelName,panel);
        }
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = sortOrder;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);

        panel.gameObject.SetActive(true);
        System.Type type = System.Type.GetType(panelName);
        UIBase uibase = panel.GetComponent(type) as UIBase;
        if (uibase == null){
            uibase = panel.AddComponent(type) as UIBase;
        }
        uibase.InitComponent();
        uibase.Reg();
        uibase.AddEvent();
        if (parms.Length > 0)
        {
            uibase.EnablePanel(parms);
        }
        else
        {
            uibase.EnablePanel();
        }

        return uibase;
    }

    public void ClosePanel(string panelName){
        if (panelCache.ContainsKey(panelName)){
            GameObject panel = panelCache[panelName];
            UIBase uibase = panel.GetComponent<UIBase>();
            uibase.UnReg();
            uibase.RemoveEvent();
            uibase.DisablePanel();
            GameObject.Destroy(panel.gameObject);
            panelCache.Remove(panelName);
        }
    }

    public void HidePanel(string panelName){
        if (panelCache.ContainsKey(panelName)){
            GameObject panel = panelCache[panelName];
            UIBase uibase = panel.GetComponent<UIBase>();
            uibase.UnReg();
            uibase.RemoveEvent();
            uibase.DisablePanel();
            panel.gameObject.SetActive(false);
        }
    }
}
