using System.Collections;
using System.Collections.Generic;
using cfg.item;
using UnityEngine;

public class EquipItemDataData : ItemDataBase
{
    public cfg.item.EEquipType equipType;
    public EquipItemDataData(int id, EType itemType, int cnt = 1) : base(id, itemType, cnt)
    {
        
    }
}
