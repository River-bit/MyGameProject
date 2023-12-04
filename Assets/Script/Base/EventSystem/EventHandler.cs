using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EventHandler : Common.SigletonBase<EventHandler>{
    public delegate void EventFunc(params object[] param);
    public delegate void EventFunc2();
    public Dictionary<string,EventFunc> m_eventDic1 = new Dictionary<string, EventFunc>();
    public Dictionary<string,EventFunc2> m_eventDic2 = new Dictionary<string, EventFunc2>();
    public void Reg(string eventName,EventFunc func){
        if (m_eventDic1.ContainsKey(eventName))
        {
            Debug.LogError("Event has been exist!!");
        }
        else{
            m_eventDic1.Add(eventName,func);
        }
    }
    public void Unreg(string eventName){
        if (m_eventDic1.ContainsKey(eventName))
        {
            m_eventDic1.Remove(eventName);
        }
        if (m_eventDic2.ContainsKey(eventName))
        {
            m_eventDic2.Remove(eventName);
        }
    }
    public void Call(string eventName,params object[] param){
        if (m_eventDic1.ContainsKey(eventName))
        {
            m_eventDic1[eventName](param);
        }
        else{
            Debug.LogWarning("Event don't exist!!");
        }
    }
    public void Reg(string eventName, EventFunc2 func)
    {
        if (m_eventDic2.ContainsKey(eventName))
        {
            Debug.LogError("Event has been exist!!");
        }
        else
        {
            m_eventDic2.Add(eventName, func);
        }
    }
    public void Call(string eventName)
    {
        if (m_eventDic2.ContainsKey(eventName))
        {
            m_eventDic2[eventName]();
        }
        else
        {
            Debug.LogWarning("Event don't exist!!");
        }
    }
}
