using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_RechargeState : RechargeState
{
   Enemy1 enemy;
   float rechargeTime = 4f;
   public E1_RechargeState(FiniteStateMachine stateMachine, Entity entity, Enemy1 enemy) : base(stateMachine, entity)
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
      {
         if (Time.time > startTime + rechargeTime)
         {
            stateMachine.ChangeState(enemy.moveState);
         }
      }
   }

   public override void PhysicsUpdate()
   {
      base.PhysicsUpdate();
   }

}
