using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using Common.Fsm;
using UnityEditor.UI;
using UnityEngine;

namespace Procedure
{
    public class ProcedureManager : SigletonBase<ProcedureManager>
    {
        private IFsm<ProcedureManager> _fsm;
        public void Init()
        {
            var stateTypeList = TypeHelper.GetRuntimeTypeNames(typeof(ProcedureState));
            ProcedureState[] states = new ProcedureState[stateTypeList.Length];
            for (int i = 0; i < stateTypeList.Length; i++)
            {
                var typeName = stateTypeList[i];
                states[i] = Activator.CreateInstance(Type.GetType(typeName) ?? throw new MyException($"'{typeName}' is not exist!!")) as ProcedureState;
            }
            _fsm = FsmManager.Instance.CreateFsm<ProcedureManager>("ProcedureFsm",this, states);
        }
        public void StartState<T>() where T:ProcedureState
        {
            if (_fsm == null)
            {
                throw new MyException("You must initialize procedure first.");
            }
            _fsm.Start<T>();
        }
        public void StartState(Type type)
        {
            if (_fsm == null)
            {
                throw new MyException("You must initialize procedure first.");
            }
            _fsm.Start(type);
        }
    }
}
