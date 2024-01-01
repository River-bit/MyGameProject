using System;
using System.Collections;
using System.Collections.Generic;
using LifeGame.Chara;
using UnityEngine;

namespace LifeGame.Model
{
    public class CharaMakeModel : BaseModel<CharaMakeModel>
    {
        private int[] _looks;
        private List<List<int>> _selectableItemList = new List<List<int>>();
        private int _charaId;

        private readonly CharaManager _charaMgr = CharaManager.Instance;

        public void SetChara(int charaId)
        {
            _charaId = charaId;
            _looks = _charaMgr.GetLooksInfo(_charaId) ?? new int[Enum.GetNames(Type.GetType("cfg.chara.ESkinType") ?? throw new InvalidOperationException()).Length];
        }
        public void SetLooks(cfg.chara.ESkinType type,int val)
        {
            if (_looks == null) return;
            _looks[(int) type] = val;
            EventCall("UpdateView");
        }
        public void SaveLooks(int charaId)
        {
            _charaMgr.SetLooks(charaId,_looks);
        }
    }
}
