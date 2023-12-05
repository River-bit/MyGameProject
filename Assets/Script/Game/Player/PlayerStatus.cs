using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus:Common.SigletonBase<PlayerStatus>
{
    private int _stressVal = 0;
    private int _energyVal = 0;
    private int _healthVal;
    
    private int _stressMax;
    private int _energyMax;

    public void StressChange(int val)
    {
        _stressVal += val;
        _stressVal = Math.Clamp(_stressVal, 0, _stressMax);
        EventHandler.Instance.Call("onStressValChange");
    }
    
    public void EnergyChange(int val)
    {
        _energyVal += val;
        _energyVal = Math.Clamp(_energyVal, 0, _energyMax);
        EventHandler.Instance.Call("onEnergyValChange");
    }
    
    public void HealthChange(int val)
    {
        _healthVal += val;
        _healthVal = Math.Clamp(_healthVal, 0, 100);
        EventHandler.Instance.Call("onHealthValChange");
    }

    public int GetStressVal()
    {
        return _stressVal;
    }
    
    public int GetStressMax()
    {
        return _stressMax;
    }
    
    public int GetEnergyVal()
    {
        return _energyVal;
    }
    
    public int GetEnergyMax()
    {
        return _energyMax;
    }

    public int GetHealthVal()
    {
        return _healthVal;
    }
}
