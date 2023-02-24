using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster5att : MonoBehaviour
{    
public float speed = 10f;
    private Transform player;
private Vector2 target;
    void Start()
    {
     player = GameObject.FindGameObjectWithTag("Player").transform;
     target = new Vector2(player.position.x, player.position.y);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =Vector2.MoveTowards(transform.position, target,speed * Time.deltaTime);
        if(transform.position.x == target.x + 5f || transform.position.y == target.y + 5f){
			Destroy(gameObject);
        }
    }


    	void OnTriggerEnter2D (Collider2D hitInfo)
	{	
		Shot enemy = hitInfo.GetComponent<Shot>();
		if (enemy != null)
		{					
			Destroy(gameObject);
		}


	}

   
}
