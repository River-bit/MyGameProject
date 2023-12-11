using System.Collections;
using System.Collections.Generic;
using cfg.chara;
using cfg.item;
using UnityEngine;

public abstract class ItemDataBase
{
    public ItemDataBase(int id,EType itemType,int cnt = 1)
    {
        this.id = id;
        this.type = itemType;
        this.count = cnt;
    }
    public int id;
    public cfg.item.EType type;
    public int count;
}

