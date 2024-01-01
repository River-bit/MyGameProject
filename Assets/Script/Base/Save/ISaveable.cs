namespace Common.Save
{
    /// <summary>
    /// 需要保存数据的类继承
    /// </summary>
    public interface ISaveAble
    {
        /// <summary>
        /// 每个存档对象唯一标识
        /// </summary>
        int saveId { get; }
        /// <summary>
        /// 调用SaveManager.Instance.SaveData
        /// </summary>
        void Save();
        /// <summary>
        /// 调用SaveManager.Instance.LoadData
        /// </summary>
        void Load();
        void RegSaveLoadFunc();
    }
}