using System;
using System.Collections;
using System.Collections.Generic;
using cfg;
using UnityEngine;

namespace LifeGame.Chara
{
    [Serializable]
    public abstract class CharaDataBase
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int id { get; }
        /// <summary>
        /// 金钱
        /// </summary>
        public int money { get; private set; }
        /// <summary>
        /// 外貌
        /// </summary>
        public int[] looks{ get; private set; }
        /// <summary>
        /// 装备
        /// </summary>
        public int[] equips{ get;private set; }
        /// <summary>
        /// 技能
        /// </summary>
        public int[] skills{ get;private set; }
        /// <summary>
        /// 属性
        /// </summary>
        public int[] attributes{ get;private set; }
        /// <summary>
        /// Buff
        /// </summary>
        public int[] buffs{ get;private set; }

        public CharaDataBase(int charaId)
        {
            id = charaId;
            money = 0;
            var equipLength = System.Enum.GetNames(Type.GetType("cfg.item.EEquip") ?? throw new InvalidOperationException()).Length;
            var lookLength = System.Enum.GetNames(Type.GetType("cfg.chara.ESkinType") ?? throw new InvalidOperationException()).Length;
            equips = new int[equipLength];
            looks = new int[lookLength];
        }
        public void AddMoney(int moneyNum)
        {
            this.money += moneyNum;
        }
        public void CostMoney(int moneyNum)
        {
            this.money -= moneyNum;
        }

        public void SetLooks(cfg.chara.ESkinType type, int lookId)
        {
            this.looks[(int) type] = lookId;
        }

        public void SetLooks(int[] newLooks)
        {
            this.looks = newLooks;
        }

        public void SetEquip(cfg.item.EEquipType type, int equipId)
        {
            this.equips[(int) type] = equipId;
        }
    }

    [Serializable]
    public class PlayerData : CharaDataBase
    {
        public int strength;
        public int stress;
        public int health;
        public int mood;
        public PlayerData(int charaId) : base(charaId)
        {
        }
    }

    [Serializable]
    public class NpcData : CharaDataBase
    {
        public int like;
        public NpcData(int charaId) : base(charaId)
        {
        }
    }
}
