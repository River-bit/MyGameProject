
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestTestScriptableObject struct {
    Id int32
    Desc string
    Rate float32
    Num int32
    V2 *vec2
    V3 *vec3
    V4 *vec4
}

const TypeId_TestTestScriptableObject = -1896814350

func (*TestTestScriptableObject) GetTypeId() int32 {
    return -1896814350
}

func NewTestTestScriptableObject(_buf map[string]interface{}) (_v *TestTestScriptableObject, err error) {
    _v = &TestTestScriptableObject{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["rate"].(float64); !_ok_ { err = errors.New("rate error"); return }; _v.Rate = float32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["v2"].(map[string]interface{}); !_ok_ { err = errors.New("v2 error"); return }; if _v.V2, err = Newvec2(_x_); err != nil { return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["v3"].(map[string]interface{}); !_ok_ { err = errors.New("v3 error"); return }; if _v.V3, err = Newvec3(_x_); err != nil { return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["v4"].(map[string]interface{}); !_ok_ { err = errors.New("v4 error"); return }; if _v.V4, err = Newvec4(_x_); err != nil { return } }
    return
}

