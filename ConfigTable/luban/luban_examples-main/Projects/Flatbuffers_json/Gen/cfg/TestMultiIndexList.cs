// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestMultiIndexList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestMultiIndexList GetRootAsTestMultiIndexList(ByteBuffer _bb) { return GetRootAsTestMultiIndexList(_bb, new TestMultiIndexList()); }
  public static TestMultiIndexList GetRootAsTestMultiIndexList(ByteBuffer _bb, TestMultiIndexList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestMultiIndexList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id1 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Id2 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Id3 { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetId3Bytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetId3Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetId3Array() { return __p.__vector_as_array<byte>(8); }
  public int Num { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Desc { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<cfg.TestMultiIndexList> CreateTestMultiIndexList(FlatBufferBuilder builder,
      int id1 = 0,
      long id2 = 0,
      StringOffset id3Offset = default(StringOffset),
      int num = 0,
      StringOffset descOffset = default(StringOffset)) {
    builder.StartTable(5);
    TestMultiIndexList.AddId2(builder, id2);
    TestMultiIndexList.AddDesc(builder, descOffset);
    TestMultiIndexList.AddNum(builder, num);
    TestMultiIndexList.AddId3(builder, id3Offset);
    TestMultiIndexList.AddId1(builder, id1);
    return TestMultiIndexList.EndTestMultiIndexList(builder);
  }

  public static void StartTestMultiIndexList(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId1(FlatBufferBuilder builder, int id1) { builder.AddInt(0, id1, 0); }
  public static void AddId2(FlatBufferBuilder builder, long id2) { builder.AddLong(1, id2, 0); }
  public static void AddId3(FlatBufferBuilder builder, StringOffset id3Offset) { builder.AddOffset(2, id3Offset.Value, 0); }
  public static void AddNum(FlatBufferBuilder builder, int num) { builder.AddInt(3, num, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(4, descOffset.Value, 0); }
  public static Offset<cfg.TestMultiIndexList> EndTestMultiIndexList(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestMultiIndexList>(o);
  }
}


static public class TestMultiIndexListVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Id2*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*Id3*/, false)
      && verifier.VerifyField(tablePos, 10 /*Num*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*Desc*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}