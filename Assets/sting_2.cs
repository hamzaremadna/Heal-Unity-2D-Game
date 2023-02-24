using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sting_2 : MonoBehaviour
{    
public float speed;
	public int damage;
    private Transform player;
private Vector2 target;
	public Rigidbody2D rb;

    void Start()
    {
     player = GameObject.FindGameObjectWithTag("Player").transform;
     target = (player.position - transform.position).normalized * speed;   
     
       rb.velocity = target;
     Destroy(gameObject,3f);
        }

    // Update is called once per frame


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
