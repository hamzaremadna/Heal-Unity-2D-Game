using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster5 : StateMachineBehaviour
{
    	public float speed = 2.5f;
	public float move = 10f;
    public float stop = 10f;
	public float attackdis = 10f;
	public float attackstart;
public float attackdelay;
public GameObject projectile;
public GameObject projectile2;

bool a = true;


	Transform player;
	Rigidbody2D rb;
	lookatplayer boss;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		rb = animator.GetComponent<Rigidbody2D>();
		boss = animator.GetComponent<lookatplayer>();

	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{            
	       boss.LookAtPlayer();

	    if(Vector2.Distance(rb.position,player.position) < move && Vector2.Distance(rb.position,player.position) > stop){
        
		Vector2 target = new Vector2(player.position.x, player.position.y);
		Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);	         
		rb.MovePosition(newPos);
    
        }
		else
		{
	    rb.position = this.rb.position;

		}
    
       if(Vector2.Distance(rb.position,player.position) <= attackdis){
     if(attackstart <= 0){
      if(a){
      Instantiate(projectile,rb.position,Quaternion.identity);
	  a = false;}
	 else{
      Instantiate(projectile2,rb.position,Quaternion.identity);
     a = true;
	 }
         attackstart = attackdelay;
    }else{
        attackstart -= Time.deltaTime;
    } 
	
	 }
    


	}


	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

}
