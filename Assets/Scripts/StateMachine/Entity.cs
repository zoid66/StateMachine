using UnityEngine;

public class Entity : MonoBehaviour
{
   public int facingDirection;
   public int noOfIdle;
   [SerializeField] Transform ledgeCheckTransform;
   [SerializeField] LayerMask whatIsGround;
   public FiniteStateMachine stateMachine { get; private set; }
   public Rigidbody2D rB { get; private set; }
   public GameObject aliveGO { get; private set; }
   public SpriteRenderer sR { get; private set; }

   public virtual void Start()
   {
      facingDirection = 1;
      aliveGO = GameObject.Find("AliveGO").gameObject;
      rB = aliveGO.GetComponent<Rigidbody2D>();
      stateMachine = new FiniteStateMachine();
      sR = aliveGO.GetComponent<SpriteRenderer>();
   }
   public virtual void Update()
   {
      stateMachine.currentState.LogicUpdate();


   }
   public virtual void FixedUpdate()
   {
      stateMachine.currentState.PhysicsUpdate();

   }
   public virtual void Flip()
   {
      facingDirection *= -1;
      noOfIdle++;
      aliveGO.transform.Rotate(0, 180, 0);
   }
   public virtual void SetVelocity(float velocity)
   {
      rB.velocity = new Vector2(facingDirection * velocity, rB.velocity.y);
   }
   public virtual bool CheckLege()
   {
      return Physics2D.Raycast(ledgeCheckTransform.position, Vector2.down, 1f, whatIsGround);
   }
   public virtual bool TimeToRecharge(float times)
   {
      if (noOfIdle > times)
      {
         return true;
      }
      else
      {
         return false;
      }
   }
   public virtual void ResetNoOfIdels()
   {
      noOfIdle = 0;
   }
   public virtual void SetColor(Color color)
   {
      sR.color = color;
   }
   private void OnDrawGizmos()
   {
      Gizmos.DrawLine(ledgeCheckTransform.position, ledgeCheckTransform.position + (Vector3)(Vector2.down * 1f));
   }
}
