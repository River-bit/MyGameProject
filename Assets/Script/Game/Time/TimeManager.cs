using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : Common.SigletonMonoBase<TimeManager>
{
    private int _year;
    private int _mouth;
    private int _day;
    private int _hour;
    private int _minute;

    private void FixTime()
    {
        _hour += _minute / 60;
        _minute %= 60;
        
        _day += _hour / 24;
        _hour %= 24;
        
        _mouth += (_day-1) / 28;
        _day = (_day-1)%28 + 1;

        _year += (_mouth - 1) / 4;
        _mouth = (_mouth - 1) % 4 + 1;
    }

    public void AddMinute(int minute)
    {
        _minute += minute;
        FixTime();
    }
    public void AddHour(int hour)
    {
        _hour += hour;
        FixTime();
    }
    public void AddDay(int day)
    {
        _day += day;
        FixTime();
    }
    public void AddMouth(int mouth)
    {
        _mouth += mouth;
        FixTime();
    }
    public void AddYear(int year)
    {
        _year += year;
        FixTime();
    }

    public int GetMinute()
    {
        return _minute;
    }
    public int GetHour()
    {
        return _hour;
    }
    public int GetDay()
    {
        return _day;
    }
    public int GetMouth()
    {
        return _mouth;
    }
    public int GetYear()
    {
        return _year;
    }
}
