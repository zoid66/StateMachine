using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
   protected float noOfIdlesBeforeRechargeTime = 4;
   protected bool isTimeToRecharge;
   protected bool isDetectingLedge;
   public MoveState(FiniteStateMachine stateMachine, Entity entity) : base(stateMachine, entity)
   {
   }
   public override void Enter()
   {
      base.Enter();
      isDetectingLedge = entity.CheckLege();
   }
   public override void LogicUpdate()
   {
      if (entity.TimeToRecharge(noOfIdlesBeforeRechargeTime))
      {
         isTimeToRecharge = true;
      }
      else
      {
         isTimeToRecharge = false;
      }
      base.LogicUpdate();

      entity.SetVelocity(1);
   }
   public override void PhysicsUpdate()
   {
      isDetectingLedge = entity.CheckLege();

   }

}
