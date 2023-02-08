using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeState : State
{


   public RechargeState(FiniteStateMachine stateMachine, Entity entity) : base(stateMachine, entity)
   {
   }
   public override void Enter()
   {
      base.Enter();
      entity.SetVelocity(0);
      entity.SetColor(Color.green);
   }

   public override void LogicUpdate()
   {
      base.LogicUpdate();

   }
   public override void Exit()
   {
      base.Exit();
      entity.SetColor(Color.red);
      entity.ResetNoOfIdels();
   }
}
