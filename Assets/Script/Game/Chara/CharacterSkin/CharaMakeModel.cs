using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMakeModel : BaseModel<CharaMakeModel>
{
    private CharaSkinInfo _curInfo;
    private List<List<int>> _selectabelItemList = new List<List<int>>();
    //标准身高
    private int[] _standHeight = new int[2] {170, 160};
    public void SetChara(int charaIndex)
    {
        _curInfo = CharaManager.Instance.GetSkinInfo(charaIndex);
        if (_curInfo == null)
        {
            //玩家
            if (charaIndex == 0)
            {
                CharaManager.Instance.GenerateNewPlayer();
            }
        }
        _curInfo = CharaManager.Instance.GetSkinInfo(charaIndex);
    }
    public void SetGender(int index,int gender)
    {
        if (gender > 1)
        {
            Debug.LogError("No Such Gender!");
        }
        if (_curInfo == null) return;
        _curInfo.Gender = gender;
        EventCall("ViewUpdate",index);
    }
    public void SetHeight(int index,int height)
    {
        if (_curInfo == null) return;
        _curInfo.Height = height;
        EventCall("ViewUpdate",index);
    }
    public void SetFigure(int index,int figure)
    {
        if (_curInfo == null) return;
        _curInfo.Figure = figure;
        EventCall("ViewUpdate",index);
    }
    public void SetColor(int index,int color)
    {
        if (_curInfo == null) return;
        _curInfo.Color = color;
        EventCall("ViewUpdate",index);
    }
}
