
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

type AiUpdateDailyBehaviorProps struct {
    Id int32
    NodeName string
    SatietyKey string
    EnergyKey string
    MoodKey string
    SatietyLowerThresholdKey string
    SatietyUpperThresholdKey string
    EnergyLowerThresholdKey string
    EnergyUpperThresholdKey string
    MoodLowerThresholdKey string
    MoodUpperThresholdKey string
}

const TypeId_AiUpdateDailyBehaviorProps = -61887372

func (*AiUpdateDailyBehaviorProps) GetTypeId() int32 {
    return -61887372
}

func NewAiUpdateDailyBehaviorProps(_buf *luban.ByteBuf) (_v *AiUpdateDailyBehaviorProps, err error) {
    _v = &AiUpdateDailyBehaviorProps{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.SatietyKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.EnergyKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.MoodKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.SatietyLowerThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.SatietyUpperThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.EnergyLowerThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.EnergyUpperThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.MoodLowerThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.MoodUpperThresholdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    return
}

