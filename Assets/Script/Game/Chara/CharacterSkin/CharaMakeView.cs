using System.Collections;
using System.Collections.Generic;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using UnityEngine;

public class CharaMakeView : BaseView
{
    private CharaMakeModel _model = CharaMakeModel.Instance;
    private CharaSkinInfo _info;

    public override void UpdateView(BaseModel model, params object[] args)
    {
    }
    public override void InitData(params object[] args)
    {
        int charaIndex = (int) args[0];
        _model.SetChara(charaIndex);
    }
    public override void InitView()
    {
    }

    public override void DisableView()
    {
    }
}
