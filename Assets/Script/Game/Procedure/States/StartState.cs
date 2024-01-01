using System.Collections;
using System.Collections.Generic;
using Common.Fsm;
using UnityEngine;

namespace Procedure
{
    public class StartState : ProcedureState
    {
        protected internal override void OnInit(IFsm<ProcedureManager> fsm)
        {
            base.OnInit(fsm);
            Debug.Log("StartState:OnInit");
            UIManager.Instance.ShowPanel("CharaMakePanel",0);
        }
        protected internal override void OnEnter(IFsm<ProcedureManager> fsm)
        {
            base.OnEnter(fsm);
            Debug.Log("StartState:OnEnter");
        }
        protected internal override void OnDestroy(IFsm<ProcedureManager> fsm)
        {
            base.OnDestroy(fsm);
            Debug.Log("StartState:OnDestroy");
        }
        protected internal override void OnLeave(IFsm<ProcedureManager> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
            Debug.Log("StartState:OnLeave");
        }
    }
}
