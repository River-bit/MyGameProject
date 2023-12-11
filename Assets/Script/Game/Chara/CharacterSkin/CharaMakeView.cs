using System.Collections;
using System.Collections.Generic;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using UnityEngine;

public class CharaMakeView : BaseView
{
    private readonly CharaMakeModel _model = CharaMakeModel.Instance;
    private CharaSkinInfo _info;
    private List<ItemDataBase> _equip;

    public override void UpdateView(BaseModel model, params object[] args)
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
        
    }

    public override void DisableView()
    {
    }
}
