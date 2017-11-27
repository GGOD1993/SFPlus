using GameFramework;
using GameFramework.Localization;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Debug.LogError("onenter launch");
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            Debug.LogError("onupdate launch");
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            ChangeState<ProcedureSplash>(procedureOwner);
        }

        protected override void OnInit(ProcedureOwner procedureOwner)
        {
            Debug.LogError("oninit launch");
        }

        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            Debug.LogError("onleave launch" + isShutdown);
        }

        protected override void OnDestroy(ProcedureOwner procedureOwner)
        {
            Debug.LogError("onDestroy launch");
        }
    }
}