using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMakeController : BaseController
{
    public override void BindMvc()
    {
        _model = CharaMakeModel.Instance;
        _view = GetComponent<CharaMakeView>();
    }
}
