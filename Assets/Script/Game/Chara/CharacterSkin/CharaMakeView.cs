using System.Collections;
using System.Collections.Generic;
using Common;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using UnityEngine;
using UnityEngine.UI;

public class CharaMakeView : BaseView
{
    private readonly CharaMakeModel _model = CharaMakeModel.Instance;
    private CharaSkinInfo _info;
    private List<ItemDataBase> _equip;
    private Transform _item;
    private Transform _parent;
    private int _curPage = 0;

    public override void UpdateView(params object[] args)
    {
        TransformHelper.HideAllChildren(_parent);
        if (_curPage == 0)
        {
            UpdateSkinMakeView();
        }
        else if (_curPage == 1)
        {
            UpdateEquipMakeView();
        }
    }

    private void UpdateEquipMakeView()
    {
    }

    private void UpdateSkinMakeView()
    {
    }

    public override void InitData(params object[] args)
    {
        int charaIndex = args.Length >0? (int) args[0]:0;
        _model.SetChara(charaIndex);
        _info = CharaManager.Instance.GetSkinInfo(charaIndex);
        _equip = WarehouseModel.Instance.GetAllEquipItem(charaIndex);
    }
    public override void InitView()
    {
        _item = UIs["selectItem"]?.transform;
        _parent = UIs["selection"].transform;
        _item?.gameObject.SetActive(false);
        
        InitToggleGroup();
        UpdateView();
    }

    public void InitToggleGroup()
    {
        var togGroup = UITools.AddToggleGroup(UIs["ToggleGroup"], UIs["togItem"]);
        togGroup.AddToggle((isOn) =>
        {
            if (isOn)
            {
                _curPage = 0;
                UpdateView();
            }
        }, (Transform item) =>
        {
            var text = TransformHelper.GetCompnent<Text>(item, "Label");
            text.text = "Tog0";
        });
        togGroup.AddToggle((isOn) =>
        {
            if (isOn)
            {
                _curPage = 1;
                UpdateView();
            }
        }, (Transform item) =>
        {
            var text = TransformHelper.GetCompnent<Text>(item, "Label");
            text.text = "Tog1";
        });
    }

    public override void DisableView()
    {
    }
}
