using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Entity
{
   public E2_IdleState idleState { get; private set; }

   public E2_MoveState moveState { get; private set; }
   public override void Start()
   {
      base.Start();
      idleState = new E2_IdleState(stateMachine, this, this);
      moveState = new E2_MoveState(stateMachine, this, this);
      stateMachine.Initialize(moveState);
   }
}
