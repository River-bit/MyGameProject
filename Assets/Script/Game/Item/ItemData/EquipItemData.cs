using System.Collections;
using System.Collections.Generic;
using cfg.item;
using UnityEngine;

namespace LifeGame.Item
{
    public class EquipItemData : ItemDataBase
    {
        public cfg.item.EEquipType EquipType;
        public EquipItemData(int id, EType itemType, int cnt = 1) : base(id, itemType, cnt)
        {
        
        }
    }
}
