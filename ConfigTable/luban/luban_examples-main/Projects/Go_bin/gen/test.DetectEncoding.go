
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

type TestDetectEncoding struct {
    Id int32
    Name string
}

const TypeId_TestDetectEncoding = -1154609646

func (*TestDetectEncoding) GetTypeId() int32 {
    return -1154609646
}

func NewTestDetectEncoding(_buf *luban.ByteBuf) (_v *TestDetectEncoding, err error) {
    _v = &TestDetectEncoding{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    return
}

