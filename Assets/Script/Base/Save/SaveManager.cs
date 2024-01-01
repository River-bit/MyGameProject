using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using Newtonsoft.Json;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace Common.Save
{
    public delegate void SaveLoadHandler();
    class SaveManager : Common.SigletonBase<SaveManager>
    {
        public static event SaveLoadHandler Save;
        public static event SaveLoadHandler Load;

        /// <summary>
        /// 当前存档数据
        /// </summary>
        private static Dictionary<int, string> _saveData = new Dictionary<int, string>();

        /// <summary>
        /// 保存数据到文件
        /// </summary>
        /// <param name="savePath"></param>
        public void SaveByJson(string savePath)
        {
            Save?.Invoke();
            string dataJson = JsonConvert.SerializeObject(_saveData);

            var path = System.IO.Path.Combine(Application.persistentDataPath, savePath + ".sav");

            try
            {
                File.WriteAllText(path, dataJson);

#if UNITY_EDITOR
                Debug.Log($"Successfully save file to {path} . ");
#endif
            }
            catch (System.Exception exception)
            {
#if UNITY_EDITOR
                Debug.LogError($"Failed to save file to {path}\n {exception}");
#endif
            }
        }

        //读取存档文件
        public void LoadFromJson(string savePath)
        {
            var path = System.IO.Path.Combine(Application.persistentDataPath, savePath + ".sav");

            try
            {
                string json = File.ReadAllText(path);
                _saveData = JsonConvert.DeserializeObject<Dictionary<int,string>>(json);
            }
            catch (System.Exception exception)
            {
#if UNITY_EDITOR
                Debug.LogError($"Failed to load file to {path}\n {exception}");
#endif
            }
            Load?.Invoke();
        }

        //保存数据到列表,在Save事件中调用
        public void SaveData<T>(int saveId,T data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            _saveData[saveId] = jsonData;
        }

        //获取列表里的数据，在Load事件中调用
        public T LoadData<T>(int saveId)
        {
            if (_saveData.ContainsKey(saveId))
            {
                string data = _saveData[saveId];
                return JsonConvert.DeserializeObject<T>(data);
            }
            else
            {
                return default(T);
            }
        }

        public void RegSaveEvent<T>(T saveObj) where T : ISaveAble
        {
            Save += saveObj.Save;
            Load += saveObj.Load;
        }
    }
}