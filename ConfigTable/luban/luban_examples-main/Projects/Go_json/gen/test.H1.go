
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestH1 struct {
    Y2 *TestH2
    Y3 int32
}

const TypeId_TestH1 = -1422503995

func (*TestH1) GetTypeId() int32 {
    return -1422503995
}

func NewTestH1(_buf map[string]interface{}) (_v *TestH1, err error) {
    _v = &TestH1{}
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["y2"].(map[string]interface{}); !_ok_ { err = errors.New("y2 error"); return }; if _v.Y2, err = NewTestH2(_x_); err != nil { return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["y3"].(float64); !_ok_ { err = errors.New("y3 error"); return }; _v.Y3 = int32(_tempNum_) }
    return
}

