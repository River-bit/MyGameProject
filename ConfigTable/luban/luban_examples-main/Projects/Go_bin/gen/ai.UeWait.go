
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

type AiUeWait struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    IgnoreRestartSelf bool
    WaitTime float32
    RandomDeviation float32
}

const TypeId_AiUeWait = -512994101

func (*AiUeWait) GetTypeId() int32 {
    return -512994101
}

func NewAiUeWait(_buf *luban.ByteBuf) (_v *AiUeWait, err error) {
    _v = &AiUeWait{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    {_v.Decorators = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = NewAiDecorator(_buf); err != nil { err = errors.New("error"); return } }; _v.Decorators = append(_v.Decorators, _e_) } }
    {_v.Services = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = NewAiService(_buf); err != nil { err = errors.New("error"); return } }; _v.Services = append(_v.Services, _e_) } }
    { if _v.IgnoreRestartSelf, err = _buf.ReadBool(); err != nil { err = errors.New("error"); err = errors.New("error"); return } }
    { if _v.WaitTime, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.RandomDeviation, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    return
}

