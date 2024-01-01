using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class SigletonBase<T> where T:new(){
        static private T _instance;
        static public T Instance{
            get{
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
            private set{}
        }
    }

    public class SigletonMonoBase<T>:MonoBehaviour where T:SigletonMonoBase<T>{
        static private T _instance;
        static public T Instance{
            get{
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        var go = FindObjectOfType<T>()?.gameObject;
                        if (go != null)
                        {
                            _instance = go.GetComponent<T>();
                        }
                        else
                        {
                            go = new GameObject(typeof(T).Name);
                            _instance = go.AddComponent<T>();
                        }
                    }
                }
                return _instance;
            }
            private set{}
        }
    }
}