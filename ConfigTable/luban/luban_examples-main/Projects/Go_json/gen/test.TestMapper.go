
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestTestMapper struct {
    Id int32
    AudioType int32
    V2 *vec2
}

const TypeId_TestTestMapper = 149110895

func (*TestTestMapper) GetTypeId() int32 {
    return 149110895
}

func NewTestTestMapper(_buf map[string]interface{}) (_v *TestTestMapper, err error) {
    _v = &TestTestMapper{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["audio_type"].(float64); !_ok_ { err = errors.New("audio_type error"); return }; _v.AudioType = int32(_tempNum_) }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["v2"].(map[string]interface{}); !_ok_ { err = errors.New("v2 error"); return }; if _v.V2, err = Newvec2(_x_); err != nil { return } }
    return
}

