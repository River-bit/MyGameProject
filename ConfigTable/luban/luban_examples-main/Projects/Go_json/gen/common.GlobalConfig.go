
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type CommonGlobalConfig struct {
    X1 int32
    X2 int32
    X3 int32
    X4 int32
    X5 int32
    X6 int32
    X7 []int32
}

const TypeId_CommonGlobalConfig = -848234488

func (*CommonGlobalConfig) GetTypeId() int32 {
    return -848234488
}

func NewCommonGlobalConfig(_buf map[string]interface{}) (_v *CommonGlobalConfig, err error) {
    _v = &CommonGlobalConfig{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x2"].(float64); !_ok_ { err = errors.New("x2 error"); return }; _v.X2 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x3"].(float64); !_ok_ { err = errors.New("x3 error"); return }; _v.X3 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x4"].(float64); !_ok_ { err = errors.New("x4 error"); return }; _v.X4 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x5"].(float64); !_ok_ { err = errors.New("x5 error"); return }; _v.X5 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x6"].(float64); !_ok_ { err = errors.New("x6 error"); return }; _v.X6 = int32(_tempNum_) }
     {
                    var _arr_ []interface{}
                    var _ok_ bool
                    if _arr_, _ok_ = _buf["x7"].([]interface{}); !_ok_ { err = errors.New("x7 error"); return }
    
                    _v.X7 = make([]int32, 0, len(_arr_))
                    
                    for _, _e_ := range _arr_ {
                        var _list_v_ int32
                        { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                        _v.X7 = append(_v.X7, _list_v_)
                    }
                }

    return
}
