using System.Collections;
using System.Collections.Generic;
using cfg.chara;
using UnityEngine;

public class CharacterSkinModel : BaseModel<CharacterSkinModel>
{
    private Dictionary<int, CharaSkinInfo> _charaInfos = new Dictionary<int, CharaSkinInfo>();
    private int[] _standHeight = new int[2] {170, 160};
    public void SetGender(int index,int gender)
    {
        if (gender < 2)
        {
            var charaInfo = _charaInfos[index];
            charaInfo.Gender = gender;
            _charaInfos[index] = charaInfo;
        }
        EventCall("OnGenderChange");
    }
    public void SetHeight(int index,int height)
    {
        if (_charaInfos.ContainsKey(index))
        {
            var charaInfo = _charaInfos[index];
            charaInfo.Height = height;
            _charaInfos[index] = charaInfo;
        }
        EventCall("ViewUpdate",index);
    }
    public void SetFigure(int index,int figure)
    {
        if (_charaInfos.ContainsKey(index))
        {
            var charaInfo = _charaInfos[index];
            charaInfo.Figure = figure;
            _charaInfos[index] = charaInfo;
        }
        EventCall("ViewUpdate",index);
    }
    
    public void SetColor(int index,int color)
    {
        if (_charaInfos.ContainsKey(index))
        {
            var charaInfo = _charaInfos[index];
            charaInfo.Color = color;
            _charaInfos[index] = charaInfo;
        }
        EventCall("ViewUpdate",index);
    }

    public void SetSkinEquip(int index,ESkinEquipType type, int itemID)
    {
        var charaInfo = _charaInfos[index];
        if (charaInfo.Equip == null)
        {
            var e = new ESkinEquipType();
            var length = System.Enum.GetNames(e.GetType()).Length;
            charaInfo.Equip = new List<int>(length);
        }
        charaInfo.Equip[(int) type] = itemID;
        _charaInfos[index] = charaInfo;
        EventCall("ViewUpdate",index);
    }

    public int GetSkinItemID(int index,ESkinEquipType type)
    {
        var charaInfo = _charaInfos[index];
        return charaInfo.Equip!=null&&charaInfo.Equip.Contains((int)type)?charaInfo.Equip[(int)type]:0;
    }
}
