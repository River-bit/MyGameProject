using System.Collections;
using System.Collections.Generic;
using cfg.chara;
using UnityEngine;

public class CharacterSkinModel : BaseModel<CharacterSkinModel>
{
    //base
    private int _gender = 0;//0=male,1=famale
    private int _height = 0;
    private int _figure = 0;
    private int _color = 0;
    //skin equipment
    private List<int> _skinEquip = new List<int>();
    
    public int gender => _gender;
    public int height => _standHeight[gender]+_height;
    public int figure => _figure;
    public int color => _color;

    private int[] _standHeight = new int[2] {170, 160};

    public void SetGender(int gender)
    {
        if (gender < 2)
        {
            _gender = gender;
        }
        EventCall("OnGenderChange");
    }

    public void SetHeight(int height)
    {
        _height = height;
        EventCall("ViewUpdate");
    }

    public void SetFigure(int figure)
    {
        _figure = figure;
        EventCall("ViewUpdate");
    }
    
    public void SetColor(int color)
    {
        _color = color;
        EventCall("ViewUpdate");
    }

    public void SetSkinEquip(ESkinEquipType type, int itemID)
    {
        _skinEquip[(int) type] = itemID;
        EventCall("ViewUpdate");
    }

    public int GetSkinItemID(ESkinEquipType type)
    {
        return _skinEquip[(int) type];
    }
}
