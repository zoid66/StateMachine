using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Entity
{
   public E1_MoveState moveState { get; private set; }
   public E1_Idle idleState { get; private set; }
   public E1_RechargeState rechargeState { get; private set; }

   public override void Start()
   {
      base.Start();
      moveState = new E1_MoveState(stateMachine, this, this);
      idleState = new E1_Idle(stateMachine, this, this);
      rechargeState = new E1_RechargeState(stateMachine, this, this);
      stateMachine.Initialize(moveState);
   }
}
