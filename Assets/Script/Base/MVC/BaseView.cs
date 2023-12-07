using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseView : MonoBehaviour
{
    public abstract void UpdateView(BaseModel model,params object[] args);
    public abstract void InitData();
    public abstract void InitView();
    public abstract void DisableView();
}
