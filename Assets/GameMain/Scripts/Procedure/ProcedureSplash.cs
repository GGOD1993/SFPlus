using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityEngine;

namespace GameMain
{
    public class ProcedureSplash : ProcedureBase
    {
        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapedSeconds)
        {
            Debug.LogError("onupdate splash");
            base.OnUpdate(procedureOwner, elapseSeconds, realElapedSeconds);
        }

        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            Debug.LogError("onleave splash" + isShutdown);
        }
    }
}