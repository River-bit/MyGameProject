using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Common.UI
{
    [RequireComponent(typeof(UnityEngine.UI.ToggleGroup))]
    public class MyToggleGroup : MonoBehaviour
    {
        private List<Toggle> _toggles = new List<Toggle>();
        private Transform _itemBase;
        private ToggleGroup _toggleGroup;
        private void Awake()
        {
            _toggleGroup = GetComponent<ToggleGroup>();
            _toggleGroup.allowSwitchOff = false;
        }

        public void AddToggle(UnityAction<bool> callBack,UnityAction<Transform> itemInit)
        {
            var item = Instantiate(_itemBase, transform);
            Toggle toggle = item.GetComponent<Toggle>();
            if (toggle == null)
            {
                Debug.LogError("ToggleGroup itemBase don't get a Toggle!!");
                return;
            }
            toggle.onValueChanged.AddListener(callBack);
            itemInit?.Invoke(toggle.transform);

            toggle.group = _toggleGroup;
            _toggles.Add(toggle);
        }

        public Toggle GetItem(int index)
        {
            return _toggles.Count > index? _toggles[index]:null;
        }

        public void SetItemBase(Transform itemBase)
        {
            _itemBase = itemBase;
        }
    }
}

