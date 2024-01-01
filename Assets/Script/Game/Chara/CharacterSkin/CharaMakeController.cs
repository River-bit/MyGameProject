using System.Collections;
using System.Collections.Generic;
using LifeGame.Model;
using LifeGame.View;
using UnityEngine;

namespace LifeGame.Controller
{
    public class CharaMakeController : BaseController
    {
        public override void BindMvc()
        {
            _model = CharaMakeModel.Instance;
            _view = GetComponent<CharaMakeView>();
        }
    }
}
