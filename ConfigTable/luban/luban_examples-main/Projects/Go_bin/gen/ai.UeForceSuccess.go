
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

type AiUeForceSuccess struct {
    Id int32
    NodeName string
    FlowAbortMode int32
}

const TypeId_AiUeForceSuccess = 195054574

func (*AiUeForceSuccess) GetTypeId() int32 {
    return 195054574
}

func NewAiUeForceSuccess(_buf *luban.ByteBuf) (_v *AiUeForceSuccess, err error) {
    _v = &AiUeForceSuccess{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.FlowAbortMode, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    return
}

