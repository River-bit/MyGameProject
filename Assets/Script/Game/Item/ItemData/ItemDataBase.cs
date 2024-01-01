using System;
using System.Collections;
using System.Collections.Generic;
using cfg.chara;
using cfg.item;
using UnityEngine;
using UnityEngine.Serialization;

namespace LifeGame.Item
{
    [Serializable]
    public abstract class ItemDataBase
    {
        public ItemDataBase(int id,EType itemType,int cnt = 1)
        {
            this.id = id;
            this.itemType = itemType;
            this.count = cnt;
        }
        public int id;
        public EType itemType;
        public int count;
    }
}
