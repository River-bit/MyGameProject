using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseView : MonoBehaviour
{
    public abstract void UpdateView(BaseModel model,params object[] args);
}
