using System.Collections;
using System.Collections.Generic;
using cfg.item;
using UnityEditor;
using UnityEngine;

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
        ItemDataBase ret = itemData.ItemType switch
        {
            EType.Equip => new EquipItemDataData(itemID, itemData.ItemType),
            _ => null
        };
        return ret;
    }
    public List<ItemDataBase> GetAllEquipItem(int charIndex)
    {
        if (!_warehouse.ContainsKey(charIndex)) return null;

        var items = _warehouse[charIndex];
        var e = new cfg.item.EEquipType();
        var length = System.Enum.GetNames(e.GetType()).Length;
        List<ItemDataBase> ret = new List<ItemDataBase>(length);
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i] as EquipItemDataData;
            if (item != null && item.type == EType.Equip)
            {
                ret.Add(item);
            }
        }

        return ret;
    }
}
