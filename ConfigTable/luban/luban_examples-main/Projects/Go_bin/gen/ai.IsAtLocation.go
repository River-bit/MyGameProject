
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type AiIsAtLocation struct {
    Id int32
    NodeName string
    FlowAbortMode int32
    AcceptableRadius float32
    KeyboardKey string
    InverseCondition bool
}

const TypeId_AiIsAtLocation = 1255972344

func (*AiIsAtLocation) GetTypeId() int32 {
    return 1255972344
}

func NewAiIsAtLocation(_buf *luban.ByteBuf) (_v *AiIsAtLocation, err error) {
    _v = &AiIsAtLocation{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.FlowAbortMode, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.AcceptableRadius, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.KeyboardKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.InverseCondition, err = _buf.ReadBool(); err != nil { err = errors.New("error"); err = errors.New("error"); return } }
    return
}

