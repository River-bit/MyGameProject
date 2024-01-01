using System;
using System.Collections;
using System.Collections.Generic;
using Common.Fsm;
using UnityEngine;

namespace Procedure
{
    public abstract class ProcedureState : FsmState<ProcedureManager>
    {
        protected internal override void OnInit(IFsm<ProcedureManager> fsm)
        {
            base.OnInit(fsm);
        }

        protected internal override void OnEnter(IFsm<ProcedureManager> fsm)
        {
            base.OnEnter(fsm);
        }

        protected internal override void OnUpdate(IFsm<ProcedureManager> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
        }

        protected internal override void OnDestroy(IFsm<ProcedureManager> fsm)
        {
            base.OnDestroy(fsm);
        }

        protected internal override void OnLeave(IFsm<ProcedureManager> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
        }
    }
}
