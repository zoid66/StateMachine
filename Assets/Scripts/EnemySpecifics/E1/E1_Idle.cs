using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_Idle : IdleState
{
   Enemy1 enemy;
   public E1_Idle(FiniteStateMachine stateMachine, Entity entity, Enemy1 enemy) : base(stateMachine, entity)
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
