using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

class ABManager:Common.SigletonMonoBase<ABManager>{
    private Dictionary<string,AssetBundle> packageCache = new Dictionary<string, AssetBundle>();
    private AssetBundle mainAB;
    private AssetBundleManifest mainManifest;
    private string basePath{
        get{
            return Path.Combine(Application.streamingAssetsPath,mainabPath) ;
        }
    }
    private string mainabPath{
        get
        {
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.WindowsPlayer:
                    return "Windows";
                    break;
                case RuntimePlatform.Android:
                    return "Android";
                    break;
                case RuntimePlatform.IPhonePlayer:
                    return "IOS";
                    break;
                default:
                    return "";
            }
        }
    }

    public AssetBundle LoadAbPackage(string path){
        if (mainAB == null){
            mainAB = AssetBundle.LoadFromFile(Path.Combine(basePath,mainabPath));
            mainManifest = mainAB.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        }
        string[] dependencies = mainManifest.GetDirectDependencies(path);
        for (int i = 0; i < dependencies.Length; i++){
            if (!packageCache.ContainsKey(dependencies[i])){
                AssetBundle ab = AssetBundle.LoadFromFile(Path.Combine(basePath,dependencies[i]));
                packageCache.Add(dependencies[i],ab);
            }
        }
        if (packageCache.ContainsKey(path)){
            return packageCache[path];
        }else{
            AssetBundle ab = AssetBundle.LoadFromFile(Path.Combine(basePath, path + ".unity3d"));
            packageCache.Add(path,ab);
            return ab;
        }
    }

    #region 同步加载资源方式
    public T LoadResource<T>(string abPath,string resName)where T:Object{
        AssetBundle ab = LoadAbPackage(abPath);
        return ab.LoadAsset<T>(resName);
    }

    public Object LoadResource(string abPath,string resName){
        AssetBundle ab = LoadAbPackage(abPath);
        return ab.LoadAsset(resName);
    }
    #endregion

    #region  异步加载资源方式
    public void LoadResourceAysc(string abPath,string resName, System.Action<Object> callback){
        AssetBundle ab = LoadAbPackage(abPath);
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

    public void LoadResourceAysc(string abPath,string resName,System.Type type,System.Action<Object> callback){
        AssetBundle ab = LoadAbPackage(abPath);
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

    public void LoadResourceAysc<T>(string abPath, string resName, System.Action<Object> callback)where T:Object{
        AssetBundle ab = LoadAbPackage(abPath);
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
