using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster4 : StateMachineBehaviour
{
    	public float speed = 2.5f;
	public float move = 50f;
    public float stop = 10f;
	public float attackdis = 5f;
	public float attackstart;
public float attackdelay;
public GameObject projectile;


	Transform player;
	Rigidbody2D rb;
	lookatplayer boss;
	private Vector2 pos;


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
        
		Vector2 target = new Vector2(player.position.x, player.position.y+1.5f);
		Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);	         
		rb.MovePosition(newPos);
    
        }
		else
		{
	    rb.position = this.rb.position;
		}
        pos = new Vector2(rb.position.x, rb.position.y + 0.5f);
       if(Vector2.Distance(pos,player.position) <= attackdis){
     if(attackstart <= 0){
      Instantiate(projectile,rb.position,Quaternion.identity);
            Instantiate(projectile,rb.position,Quaternion.identity);

         attackstart = attackdelay;
    }else{
        attackstart -= Time.deltaTime;
    }  }



	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

}
