using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cfg.chara;
using cfg.item;
using Common;
using Common.Save;

namespace LifeGame.Chara
{
    /// <summary>
    /// 角色管理类
    /// </summary>
    public class CharaManager:Common.SigletonBase<CharaManager>,ISaveAble
    {
        private PlayerData _playerData;
        private Dictionary<int, NpcData> _npcDataDict = new Dictionary<int, NpcData>();
        /// <summary>
        /// 打开捏人界面
        /// </summary>
        public void OpenCharaMakePanel(int charaId)
        {
            UIManager.Instance.ShowPanel("CharaMakePanel",charaId);
        }
        public void GenerateNewNpc()
        {
        }

        public int[] GetLooksInfo(int charaId)
        {
            if (charaId == 0)
            {
                if (_playerData == null)
                {
                    throw new MyException("_playerData is null");
                }
                return _playerData.looks;
            }
            else
            {
                if (_npcDataDict.ContainsKey(charaId))
                {
                    return _npcDataDict[charaId].looks;
                }
                else
                {
                    throw new MyException($"No such npc whose id is {charaId}");
                }
            }
        }

        public void SetLooks(int charaId, ESkinType type, int val)
        {
            if (charaId == 0)
            {
                _playerData.SetLooks(type,val);
            }
            else
            {
                if (_npcDataDict.ContainsKey(charaId))
                {
                    _npcDataDict[charaId].SetLooks(type,val);
                }
                else
                {
                    throw new MyException($"No such npc whose id is {charaId}");
                }
            }
        }

        public void SetLooks(int charaId,int[] newLook)
        {
            if (charaId == 0)
            {
                _playerData.SetLooks(newLook);
            }
            else
            {
                if (_npcDataDict.ContainsKey(charaId))
                {
                    _npcDataDict[charaId].SetLooks(newLook);
                }
                else
                {
                    throw new MyException($"No such npc whose id is {charaId}");
                }
            }
        }

        public int saveId => SaveDataType.CharaMake;
        public void Save()
        {
        }

        public void Load()
        {
        }

        public void RegSaveLoadFunc()
        {
        }
    }
}
