using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
 public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;
	private Object obj;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{	

		PlayerShot enemy = hitInfo.GetComponent<PlayerShot>();
		if (enemy != null)
		{					
			Destroy(gameObject);

			enemy.TakeDamage(damage);	
		 obj = Instantiate(impactEffect, transform.position, transform.rotation);
		  Destroy(obj,0.7f);
		}else{
			Destroy(gameObject);
			 obj = Instantiate(impactEffect, transform.position, transform.rotation);
		  Destroy(obj,0.7f);}



	}
}
