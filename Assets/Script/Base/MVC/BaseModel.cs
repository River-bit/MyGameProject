using System;
using System.Collections;
using System.Collections.Generic;using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using UnityEngine;

public delegate void BroadcastAction(params object[] args);
public abstract class BaseModel
{
    protected Dictionary<string, BroadcastAction> _event = new Dictionary<string, BroadcastAction>();

    public void EventRegister(string eventName,BroadcastAction callback)
    {
        if (!_event.ContainsKey(eventName))
        {
            _event.Add(eventName,new BroadcastAction(callback));
        }
        else
        {
            _event[eventName] += callback;
        }
    }
    
    public void EventUnregister(string eventName,BroadcastAction callback)
    {
        if (_event.ContainsKey(eventName))
        {
            _event[eventName] -= callback;
        }
    }

    public void EventCall(string eventName,params object[] args)
    {
        if ( _event.ContainsKey(eventName) && _event[eventName] != null)
        {
            _event[eventName](this,args);
        }
    }
}

public class BaseModel<T>:BaseModel
{
    static private T _instance;
    static public T Instance{
        get{
            if (_instance == null)
            {
                _instance = Activator.CreateInstance<T>();
            }
            return _instance;
        }
    }
}
