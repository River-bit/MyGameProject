// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestTestSet : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestTestSet GetRootAsTestTestSet(ByteBuffer _bb) { return GetRootAsTestTestSet(_bb, new TestTestSet()); }
  public static TestTestSet GetRootAsTestTestSet(ByteBuffer _bb, TestTestSet obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTestSet __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string X0 { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetX0Bytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetX0Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetX0Array() { return __p.__vector_as_array<byte>(6); }
  public int X1(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int X1Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetX1Bytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetX1Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetX1Array() { return __p.__vector_as_array<int>(8); }
  public long X2(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int X2Length { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetX2Bytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetX2Bytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetX2Array() { return __p.__vector_as_array<long>(10); }
  public string X3(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int X3Length { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public cfg.TestDemoEnum X4(int j) { int o = __p.__offset(14); return o != 0 ? (cfg.TestDemoEnum)__p.bb.GetInt(__p.__vector(o) + j * 4) : (cfg.TestDemoEnum)0; }
  public int X4Length { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<cfg.TestDemoEnum> GetX4Bytes() { return __p.__vector_as_span<cfg.TestDemoEnum>(14, 4); }
#else
  public ArraySegment<byte>? GetX4Bytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public cfg.TestDemoEnum[] GetX4Array() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); cfg.TestDemoEnum[] a = new cfg.TestDemoEnum[l]; for (int i = 0; i < l; i++) { a[i] = (cfg.TestDemoEnum)__p.bb.GetInt(p + i * 4); } return a; }

  public static Offset<cfg.TestTestSet> CreateTestTestSet(FlatBufferBuilder builder,
      int id = 0,
      StringOffset x0Offset = default(StringOffset),
      VectorOffset x1Offset = default(VectorOffset),
      VectorOffset x2Offset = default(VectorOffset),
      VectorOffset x3Offset = default(VectorOffset),
      VectorOffset x4Offset = default(VectorOffset)) {
    builder.StartTable(6);
    TestTestSet.AddX4(builder, x4Offset);
    TestTestSet.AddX3(builder, x3Offset);
    TestTestSet.AddX2(builder, x2Offset);
    TestTestSet.AddX1(builder, x1Offset);
    TestTestSet.AddX0(builder, x0Offset);
    TestTestSet.AddId(builder, id);
    return TestTestSet.EndTestTestSet(builder);
  }

  public static void StartTestTestSet(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddX0(FlatBufferBuilder builder, StringOffset x0Offset) { builder.AddOffset(1, x0Offset.Value, 0); }
  public static void AddX1(FlatBufferBuilder builder, VectorOffset x1Offset) { builder.AddOffset(2, x1Offset.Value, 0); }
  public static VectorOffset CreateX1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateX1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartX1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddX2(FlatBufferBuilder builder, VectorOffset x2Offset) { builder.AddOffset(3, x2Offset.Value, 0); }
  public static VectorOffset CreateX2Vector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateX2VectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX2VectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartX2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddX3(FlatBufferBuilder builder, VectorOffset x3Offset) { builder.AddOffset(4, x3Offset.Value, 0); }
  public static VectorOffset CreateX3Vector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateX3VectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX3VectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX3VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartX3Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddX4(FlatBufferBuilder builder, VectorOffset x4Offset) { builder.AddOffset(5, x4Offset.Value, 0); }
  public static VectorOffset CreateX4Vector(FlatBufferBuilder builder, cfg.TestDemoEnum[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateX4VectorBlock(FlatBufferBuilder builder, cfg.TestDemoEnum[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX4VectorBlock(FlatBufferBuilder builder, ArraySegment<cfg.TestDemoEnum> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateX4VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<cfg.TestDemoEnum>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartX4Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestTestSet> EndTestTestSet(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 8);  // x1
    builder.Required(o, 10);  // x2
    builder.Required(o, 12);  // x3
    builder.Required(o, 14);  // x4
    return new Offset<cfg.TestTestSet>(o);
  }
}


static public class TestTestSetVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*X0*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*X1*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 10 /*X2*/, 8 /*long*/, true)
      && verifier.VerifyVectorOfStrings(tablePos, 12 /*X3*/, true)
      && verifier.VerifyVectorOfData(tablePos, 14 /*X4*/, 4 /*cfg.TestDemoEnum*/, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
