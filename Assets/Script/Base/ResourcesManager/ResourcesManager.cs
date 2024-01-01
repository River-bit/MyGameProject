using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Common;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using UnityEngine;
using UnityEngine.Assertions;
using Debug = System.Diagnostics.Debug;
using Object = UnityEngine.Object;

public class ResourcesManager : SigletonMonoBase<ResourcesManager>
{
    public T Load<T>(string path)where T:Object
    {
        T ret = null;
#if UNITY_EDITOR
        ret = Resources.Load<T>(path);
#else
         ret = ABManager.Instance.LoadResource<T>(path, Path.GetFileName(path));
#endif
        Assert.IsNotNull(ret,path + "资源加载失败!!!");
        return ret;
    }
}
