
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

type TestDemoD3 struct {
    X1 int32
    X3 int32
}

const TypeId_TestDemoD3 = -2138341746

func (*TestDemoD3) GetTypeId() int32 {
    return -2138341746
}

func NewTestDemoD3(_buf *luban.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case -2138341717: _v, err := NewTestDemoE1(_buf); if err != nil { return nil, errors.New("test.demoe1") } else { return _v, nil }
        case -989153243: _v, err := NewTestLoginRoleInfo(_buf); if err != nil { return nil, errors.New("test.login.roleinfo") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

