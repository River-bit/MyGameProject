
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestH2 struct {
    Z2 int32
    Z3 int32
}

const TypeId_TestH2 = -1422503994

func (*TestH2) GetTypeId() int32 {
    return -1422503994
}

func NewTestH2(_buf map[string]interface{}) (_v *TestH2, err error) {
    _v = &TestH2{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["z2"].(float64); !_ok_ { err = errors.New("z2 error"); return }; _v.Z2 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["z3"].(float64); !_ok_ { err = errors.New("z3 error"); return }; _v.Z3 = int32(_tempNum_) }
    return
}

