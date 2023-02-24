using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : StateMachineBehaviour
{
    	public float speed = 2.5f;
	public float move = 10f;
    public float stop = 1f;



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
	    if(Vector2.Distance(rb.position,player.position) < move && Vector2.Distance(rb.position,player.position) > stop){
                       boss.LookAtPlayer();
        
		Vector2 target = new Vector2(player.position.x, rb.position.y);
		Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);	         
		          if(boss.IsGrounded()){
		rb.MovePosition(newPos);}}    
		else
		{
	    rb.position = this.rb.position;

		}




	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

}
