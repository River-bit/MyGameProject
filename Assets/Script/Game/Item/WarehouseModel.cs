using System.Collections;
using System.Collections.Generic;
using cfg.item;
using Common;
using UnityEditor;
using UnityEngine;

namespace LifeGame.Item
{
    public class WarehouseModel : BaseModel<WarehouseModel>
    {
        private Dictionary<int, Dictionary<int, ItemDataBase>> _warehouse = new Dictionary<int, Dictionary<int, ItemDataBase>>();

    
        public void AddItem(int charaIndex, int itemID,int count = 1)
        {
            if (_warehouse.ContainsKey(charaIndex))
            {
                var items = _warehouse[charaIndex];
                if (items.ContainsKey(itemID))
                {
                    var itemData = items[itemID];
                    itemData.count += count;
                    items[itemID] = itemData;
                }
                else
                {
                    items.Add(itemID,NewItem(itemID));
                }
            }
            else
            {
                _warehouse.Add(charaIndex,new Dictionary<int, ItemDataBase>());
                _warehouse[charaIndex].Add(itemID,NewItem(itemID));
            }
            EventCall("OnItemAdd",charaIndex);
        }
        private ItemDataBase NewItem(int itemID)
        {
            var itemData = ConfigReader.Instance.Tables.TbItem.Get(itemID);
            if (itemData == null)
            {
                throw new MyException($"No such item which id is {itemID}");
            }
            ItemDataBase ret = itemData.ItemType switch
            {
                EType.Equip => new EquipItemData(itemID, itemData.ItemType),
                _ => null
            };
            return ret;
        }
        public List<EquipItemData> GetAllEquipItem(int charIndex)
        {
            if (!_warehouse.ContainsKey(charIndex)) return null;

            var items = _warehouse[charIndex];
            var e = new cfg.item.EEquipType();
            var length = System.Enum.GetNames(e.GetType()).Length;
            List<EquipItemData> ret = new List<EquipItemData>(length);
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] is EquipItemData item && item.itemType == EType.Equip)
                {
                    ret.Add(item);
                }
            }
            return ret;
        }
    }
}