using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
   protected FiniteStateMachine stateMachine;
   protected Entity entity;
   protected float startTime;

   public State(FiniteStateMachine stateMachine, Entity entity)
   {
      this.stateMachine = stateMachine;
      this.entity = entity;
   }

   public virtual void Enter()
   {
      startTime = Time.time;
   }
   public virtual void Exit()
   {


   }
   public virtual void LogicUpdate()
   {

   }
   public virtual void PhysicsUpdate()
   {
   }

}
