using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_IdleState : IdleState
{
   Enemy2 enemy;
   public E2_IdleState(FiniteStateMachine stateMachine, Entity entity, Enemy2 enemy) : base(stateMachine, entity)
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
      if (isIdleTimeOver)
      {

         entity.Flip();
         stateMachine.ChangeState(enemy.moveState);
      }
   }

   public override void PhysicsUpdate()
   {
      base.PhysicsUpdate();
   }
}
