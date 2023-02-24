using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monomonster5attack : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed = 20f;
	public int damage = 5;
    private Transform player;
    	public Rigidbody2D rb;

private Vector2 target;
    void Start()
    {
    
     player = GameObject.FindGameObjectWithTag("Player").transform;
     target = (player.position - transform.position).normalized * speed;   
       rb.velocity = target;
     Destroy(gameObject,3f);
    }

	void OnTriggerEnter2D (Collider2D hitInfo)
	{	
		Shot enemy = hitInfo.GetComponent<Shot>();
    		if (enemy != null)
		{					
			Destroy(gameObject);

			enemy.TakeDamage(damage);	

		}
        
         

	}
}
