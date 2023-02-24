using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class pillar : MonoBehaviour
{    
public float speed = 20f;
	public int damage = 5;
private Vector2 target;
    private Transform player;
private Vector2 target2;
     void Start()
    {
     player = GameObject.FindGameObjectWithTag("Player").transform;
     target2 = new Vector2(player.position.x, player.position.y);   
    }


    // Update is called once per frame
    void Update()
    {
             target = new Vector2(Random.Range(transform.position.x - 10f ,transform.position.x + 10f) , transform.position.y + 5f);   
        transform.position =Vector2.MoveTowards(transform.position, target,speed * Time.deltaTime);
        if( transform.position.y < target2.y - 5f){
			Destroy(gameObject);
        }
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
