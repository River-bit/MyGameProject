using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common{
    static public class TransformHelper{
        public static T GetCompnent<T>(Transform trans,string childPath = null,bool active = true)where T:Component{
            if (string.IsNullOrEmpty(childPath))
            {
                return trans.GetComponent<T>();
            }
            Transform curTrans = trans;
            string[] childList = childPath.Split("/");
            for (int i = 0; i < childList.Length; i++){
                string childName = childList[i];
                Transform nextTrans = null;
                for (int j = 0; j < curTrans.childCount; j++){
                    if (curTrans.GetChild(j).name == childName){
                        nextTrans = curTrans.GetChild(j);
                        break;
                    }
                }
                if (nextTrans == null){
                    Debug.LogError("TransformHelper:Child can`t find");
                    return null;
                }
                else{
                    curTrans = nextTrans;
                }
            }
            curTrans.gameObject.SetActive(active);
            return curTrans.GetComponent<T>();
        }
        public static void HideAllChildren(Transform trans)
        {
            for (int i = 0; i < trans.childCount; i++)
            {
                trans.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}