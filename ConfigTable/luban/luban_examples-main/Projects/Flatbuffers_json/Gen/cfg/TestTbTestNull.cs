// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestTbTestNull : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestTbTestNull GetRootAsTestTbTestNull(ByteBuffer _bb) { return GetRootAsTestTbTestNull(_bb, new TestTbTestNull()); }
  public static TestTbTestNull GetRootAsTestTbTestNull(ByteBuffer _bb, TestTbTestNull obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTbTestNull __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.TestTestNull? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (cfg.TestTestNull?)(new cfg.TestTestNull()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.TestTbTestNull> CreateTestTbTestNull(FlatBufferBuilder builder,
      VectorOffset data_listOffset = default(VectorOffset)) {
    builder.StartTable(1);
    TestTbTestNull.AddDataList(builder, data_listOffset);
    return TestTbTestNull.EndTestTbTestNull(builder);
  }

  public static void StartTestTbTestNull(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<cfg.TestTestNull>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<cfg.TestTestNull>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.TestTestNull>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.TestTestNull>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestTbTestNull> EndTestTbTestNull(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // data_list
    return new Offset<cfg.TestTbTestNull>(o);
  }
}


static public class TestTbTestNullVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, cfg.TestTestNullVerify.Verify, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
