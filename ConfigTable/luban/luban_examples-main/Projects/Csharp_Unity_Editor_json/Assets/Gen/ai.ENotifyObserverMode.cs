
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.ai
{
    public enum ENotifyObserverMode
    {
        ON_VALUE_CHANGE = 0,
        ON_RESULT_CHANGE = 1,
    }

    public static class ENotifyObserverMode_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo ON_VALUE_CHANGE = new Luban.EditorEnumItemInfo("ON_VALUE_CHANGE", "", 0, "");
        public static readonly Luban.EditorEnumItemInfo ON_RESULT_CHANGE = new Luban.EditorEnumItemInfo("ON_RESULT_CHANGE", "", 1, "");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            ON_VALUE_CHANGE,
            ON_RESULT_CHANGE,
        };

        public static System.Collections.Generic.List<Luban.EditorEnumItemInfo> GetItems() => __items;

        public static Luban.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Luban.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Luban.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }

} 
