using System.Collections;
using System.Collections.Generic;
using Procedure;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Initializer.Instance.Init();
        ProcedureManager.Instance.StartState<StartState>();
    }
}
