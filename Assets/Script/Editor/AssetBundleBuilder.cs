using System;
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
 
/// <summary>  
/// 把Resource下的资源打包成.unity3d 到StreamingAssets目录下  
/// </summary>  
public class AssetBundleBuilder : Editor
{
    public static string sourcePath = Application.dataPath + "/Resources";
    private static readonly string AssetBundlesOutputPath = Application.streamingAssetsPath;

    [MenuItem("Tools/AssetBundle/Build")]
    public static void BuildAssetBundle()
    {
        ClearAssetBundlesName();
        Pack(sourcePath);
        string outputPath = Path.Combine(AssetBundlesOutputPath, Platform.GetPlatformFolder(EditorUserBuildSettings.activeBuildTarget));
        ClearOutputPath(outputPath);
        
        //根据BuildSetting里面所激活的平台进行打包  
        BuildPipeline.BuildAssetBundles(outputPath, 0, EditorUserBuildSettings.activeBuildTarget);
        AssetDatabase.Refresh();
        Debug.Log("打包完成");
    }
    private static void ClearOutputPath(string deletePath)
    {
        if (!Directory.Exists(deletePath))
        {
            Directory.CreateDirectory(deletePath);
        }
        try
        {
            DirectoryInfo dir = new DirectoryInfo(deletePath);
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            foreach (FileSystemInfo item in files)
            {
                if (item is DirectoryInfo)//判断是否文件夹
                {
                    DirectoryInfo subdir = new DirectoryInfo(item.FullName);
                    subdir.Delete(true);//删除子目录和文件
                }
                else
                {
                    File.Delete(item.FullName);//删除指定文件
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    /// <summary>  
    /// 清除之前设置过的AssetBundleName，避免产生不必要的资源也打包  
    /// 之前说过，只要设置了AssetBundleName的，都会进行打包，不论在什么目录下  
    /// </summary>  
    static void ClearAssetBundlesName()
    {
        int length = AssetDatabase.GetAllAssetBundleNames().Length;
        Debug.Log(length);
        string[] oldAssetBundleNames = new string[length];
        for (int i = 0; i < length; i++)
        {
            oldAssetBundleNames[i] = AssetDatabase.GetAllAssetBundleNames()[i];
        }
 
        for (int j = 0; j < oldAssetBundleNames.Length; j++)
        {
            AssetDatabase.RemoveAssetBundleName(oldAssetBundleNames[j], true);
        }
        length = AssetDatabase.GetAllAssetBundleNames().Length;
        Debug.Log(length);
    }
 
    static void Pack(string source)
    {
        DirectoryInfo folder = new DirectoryInfo(source);
        FileSystemInfo[] files = folder.GetFileSystemInfos();
        int length = files.Length;
        for (int i = 0; i < length; i++)
        {
            if (files[i] is DirectoryInfo)
            {
                Pack(files[i].FullName);
            }
            else
            {
                if (!files[i].Name.EndsWith(".meta"))
                {
                    file(files[i].FullName);
                }
            }
        }
    }
 
    static void file(string source)
    {
        string _source = Replace(source);
        string _assetPath = "Assets" + _source.Substring(Application.dataPath.Length);
        string _assetPath2 = _source.Substring(Application.dataPath.Length + 1);
        Debug.Log (_assetPath);  
 
        //在代码中给资源设置AssetBundleName  
        AssetImporter assetImporter = AssetImporter.GetAtPath(_assetPath);
        string assetName = _assetPath2.Substring(_assetPath2.IndexOf("/") + 1);
        assetName = assetName.Replace(Path.GetExtension(assetName), ".unity3d");
        Debug.Log (assetName);  
        assetImporter.assetBundleName = assetName;
    }
 
    static string Replace(string s)
    {
        return s.Replace("\\", "/");
    }
}
 
public class Platform
{
    public static string GetPlatformFolder(BuildTarget target)
    {
        switch (target)
        {
            case BuildTarget.Android:
                return "Android";
            case BuildTarget.iOS:
                return "IOS";
            case BuildTarget.StandaloneWindows:
            case BuildTarget.StandaloneWindows64:
                return "Windows";
            default:
                return null;
        }
    }
}