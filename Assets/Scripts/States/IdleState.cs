using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
   protected bool isIdleTimeOver;
   protected float idleTime = 2f;
   public IdleState(FiniteStateMachine stateMachine, Entity entity) : base(stateMachine, entity)
   {

   }
   public override void Enter()
   {
      isIdleTimeOver = false;
      base.Enter();
      entity.SetVelocity(0);
   }

   public override void LogicUpdate()
   {
      base.LogicUpdate();
      if (Time.time >= startTime + idleTime)
      {
         isIdleTimeOver = true;
      }
   }
}
