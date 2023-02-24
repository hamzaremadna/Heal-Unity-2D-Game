using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatplayer : MonoBehaviour
{
 Transform player;
      public Transform monster;

 	[SerializeField] private LayerMask Ground;
	public bool isFlipped = false;

	private BoxCollider2D cc;

	public void Awake(){
          		player = GameObject.FindGameObjectWithTag("Player").transform;
		cc = monster.GetComponent<BoxCollider2D>();
	}

	public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;
		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;     

		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}

 public bool IsGrounded()
{ 
     float extraHeightText = 1f;
     RaycastHit2D hit = Physics2D.BoxCast(cc.bounds.center, cc.bounds.size,0f, Vector2.down ,extraHeightText,Ground);
       return hit.collider != null;
}
}
