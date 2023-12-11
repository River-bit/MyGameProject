using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cfg.chara;
using cfg.item;

/// <summary>
/// 角色对外管理接口类，外部组件主要通过本类与角色功能互动
/// </summary>
public class CharaManager:BaseModel<CharaManager>
{
    //角色外貌
    private Dictionary<int, CharaSkinInfo> _charaSkinInfos = new Dictionary<int, CharaSkinInfo>();
    //角色装备
    private Dictionary<int, List<int>> _charaEquip = new Dictionary<int, List<int>>();
    
    /// <summary>
    /// 打开捏人界面
    /// </summary>
    public void OpenCharaMakePanel(int charaIndex)
    {
        UIManager.Instance.ShowPanel("CharaMakePanel",charaIndex);
    }
    public void SetSkinEquip(int index,ESkinEquipType type, int itemID)
    {
        if (!_charaEquip.ContainsKey(index)) return;
        if (_charaEquip[index] == null)
        {
            var e = new ESkinEquipType();
            var length = System.Enum.GetNames(e.GetType()).Length;
            _charaEquip.Add(index,new List<int>(length));
        }
        _charaEquip[index][(int) type] = itemID;
        EventCall("ViewUpdate",index);
    }
    public int GetSkinEquipID(int index,ESkinEquipType type)
    {
        var equipInfo = _charaEquip[index];
        return equipInfo!=null&&equipInfo.Contains((int)type)?equipInfo[(int)type]:0;
    }
    public CharaSkinInfo GetSkinInfo(int charaIndex)
    {
        return _charaSkinInfos.ContainsKey(charaIndex) ? _charaSkinInfos[charaIndex] : null;
    }
    public void SetSkinInfo(int charaIndex,CharaSkinInfo newInfo)
    {
        if (_charaSkinInfos.ContainsKey(charaIndex))
        {
            _charaSkinInfos[charaIndex] = newInfo;
        }
        else
        {
            _charaSkinInfos.Add(charaIndex,newInfo);
        }
    }
    public void GenerateNewPlayer()
    {
        //Skin
        SetSkinInfo(0, new CharaSkinInfo());
        //Equip
        var e = new ESkinEquipType();
        var length = System.Enum.GetNames(e.GetType()).Length;
        _charaEquip.Add(0,new List<int>(length));
    }
}
