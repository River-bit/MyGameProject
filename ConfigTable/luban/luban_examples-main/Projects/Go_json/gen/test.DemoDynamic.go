
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestDemoDynamic struct {
    X1 int32
}

const TypeId_TestDemoDynamic = -1863156384

func (*TestDemoDynamic) GetTypeId() int32 {
    return -1863156384
}

func NewTestDemoDynamic(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "DemoD2": _v, err := NewTestDemoD2(_buf); if err != nil { return nil, errors.New("testdemod2") } else { return _v, nil }
        case "DemoE1": _v, err := NewTestDemoE1(_buf); if err != nil { return nil, errors.New("testdemoe1") } else { return _v, nil }
        case "test.login.RoleInfo": _v, err := NewTestLoginRoleInfo(_buf); if err != nil { return nil, errors.New("testloginroleinfo") } else { return _v, nil }
        case "DemoD5": _v, err := NewTestDemoD5(_buf); if err != nil { return nil, errors.New("testdemod5") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

