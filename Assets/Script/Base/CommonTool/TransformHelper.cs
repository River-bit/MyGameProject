using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common{
    static public class TransformHelper{
        static public T GetCompnent<T>(Transform trans,string childpath = null,bool active = true)where T:Component{
            if (childpath == null || childpath == "")
            {
                return trans.GetComponent<T>();
            }
            Transform curTrans = trans;
            string[] childList = childpath.Split("/");
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
    }
}