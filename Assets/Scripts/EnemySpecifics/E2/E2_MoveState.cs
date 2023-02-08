using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_MoveState : MoveState
{
   Enemy2 enemy;
   public E2_MoveState(FiniteStateMachine stateMachine, Entity entity, Enemy2 enemy) : base(stateMachine, entity)
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
   }

   public override void PhysicsUpdate()
   {
      base.PhysicsUpdate();
   }
}
