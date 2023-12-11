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
    }
    public override void InitData(params object[] args)
    {
        int charaIndex = (int) args[0];
        _model.SetChara(charaIndex);
        _info = CharaManager.Instance.GetSkinInfo(charaIndex);
        _equip = WarehouseModel.Instance.GetAllEquipItem(charaIndex);
    }
    public override void InitView()
    {
        _item = UIs["selecItem"]?.transform;
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
