
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Linq;


namespace cfg.test
{
    public partial class TbTestGlobal
    {
        private readonly System.Func<string, int, int, ByteBuf> _byteBufLoader;
        private readonly string _fileName;
        private Tables _tables;

        private readonly test.TestGlobal _data;
     
        public TbTestGlobal(ByteBuf _buf, string fileName, System.Func<string, int, int, ByteBuf> byteBufLoader)
        {
            int n = _buf.ReadSize();
            if (n != 1) throw new SerializationException("table mode=one, but size != 1");
            int offset = _buf.ReadInt();
            int length = _buf.ReadInt();
            ByteBuf dataBuf = byteBufLoader(fileName, offset, length);
            _data = test.TestGlobal.DeserializeTestGlobal(dataBuf);
        }


         public int UnlockEquip => _data.UnlockEquip;
         public int UnlockHero => _data.UnlockHero;
    
        public void ResolveRef(Tables tables)
        {
            _data.ResolveRef(tables);
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }

}
