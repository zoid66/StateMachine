using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_MoveState : MoveState
{
   float timeBeforeRecharge = 5f;
   Enemy1 enemy;
   public E1_MoveState(FiniteStateMachine stateMachine, Entity entity, Enemy1 enemy) : base(stateMachine, entity)
   {
      this.enemy = enemy;
   }

   public override void Enter()
   {
      base.Enter();
   }


   public override void Exit()
   {
      base.Exit();
   }


   public override void LogicUpdate()
   {
      base.LogicUpdate();
      if (!isDetectingLedge)
      {
         stateMachine.ChangeState(enemy.idleState);

      }
      else if (isDetectingLedge && isTimeToRecharge && Time.time > startTime + timeBeforeRecharge)
      {
         stateMachine.ChangeState(enemy.rechargeState);
      }
   }

   public override void PhysicsUpdate()
   {
      base.PhysicsUpdate();
   }

}
