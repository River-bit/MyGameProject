using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ABManager:Common.SigletonMonoBase<ABManager>{
    private Dictionary<string,AssetBundle> packageCache = new Dictionary<string, AssetBundle>();
    private AssetBundle mainAB;
    private AssetBundleManifest mainManifest;
    private string basePath{
        get{
            return Application.dataPath + "/StreamingAssets/";
        }
    }
    private string mainABName{
        get{
            return "StandaloneWindows";
        }
    }

    public AssetBundle LoadABPackage(string abName){
        if (mainAB == null){
            mainAB = AssetBundle.LoadFromFile(basePath + mainABName);
            mainManifest = mainAB.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        }
        string[] dependencies = mainManifest.GetDirectDependencies(abName);
        for (int i = 0; i < dependencies.Length; i++){
            if (!packageCache.ContainsKey(dependencies[i])){
                AssetBundle ab = AssetBundle.LoadFromFile(basePath + dependencies[i]);
                packageCache.Add(dependencies[i],ab);
            }
        }
        if (packageCache.ContainsKey(abName)){
            return packageCache[abName];
        }else{
            AssetBundle ab = AssetBundle.LoadFromFile(basePath + abName);
            packageCache.Add(abName,ab);
            return ab;
        }
    }

    #region 同步加载资源方式
    public T LoadResource<T>(string abName,string resName)where T:Object{
        AssetBundle ab = LoadABPackage(abName);
        return ab.LoadAsset<T>(resName);
    }

    public Object LoadResource(string abName,string resName){
        AssetBundle ab = LoadABPackage(abName);
        return ab.LoadAsset(resName);
    }
    #endregion

    #region  异步加载资源方式
    public void LoadResourceAysc(string abName,string resName, System.Action<Object> callback){
        AssetBundle ab = LoadABPackage(abName);
        StartCoroutine(LoadRes(ab,resName,callback));
    }
    IEnumerator LoadRes(AssetBundle ab,string resName, System.Action<Object> callback){
        if (ab == null){
            yield break;
        }
        AssetBundleRequest abr = ab.LoadAssetAsync(resName);
        yield return abr;
        callback(abr.asset);
    }

    public void LoadResourceAysc(string abName,string resName,System.Type type,System.Action<Object> callback){
        AssetBundle ab = LoadABPackage(abName);
        StartCoroutine(LoadRes(ab,resName,type,callback));
    }
    IEnumerator LoadRes(AssetBundle ab,string resName,System.Type type,System.Action<Object> callback){
        if (ab == null){
            yield break;
        }
        AssetBundleRequest abr = ab.LoadAssetAsync(resName,type);
        yield return abr;
        callback(abr.asset);
    }

    public void LoadResourceAysc<T>(string abName, string resName, System.Action<Object> callback)where T:Object{
        AssetBundle ab = LoadABPackage(abName);
        StartCoroutine(LoadRes<T>(ab, resName, callback));
    }
    IEnumerator LoadRes<T>(AssetBundle ab,string resName,System.Action<Object> callback)where T:Object{
        if (ab == null){
            yield break;
        }
        AssetBundleRequest abr = ab.LoadAssetAsync<T>(resName);
        yield return abr;
        callback(abr.asset as T);
    }
    #endregion
}
