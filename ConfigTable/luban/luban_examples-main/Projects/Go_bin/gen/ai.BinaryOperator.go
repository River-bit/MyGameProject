
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

type AiBinaryOperator struct {
    Oper int32
    Data interface{}
}

const TypeId_AiBinaryOperator = -979891605

func (*AiBinaryOperator) GetTypeId() int32 {
    return -979891605
}

func NewAiBinaryOperator(_buf *luban.ByteBuf) (_v *AiBinaryOperator, err error) {
    _v = &AiBinaryOperator{}
    { if _v.Oper, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Data, err = NewAiKeyData(_buf); err != nil { err = errors.New("error"); return } }
    return
}

