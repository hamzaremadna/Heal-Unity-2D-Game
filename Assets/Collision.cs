using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
      	void OnCollisionEnter2D (Collision2D hitInfo)
	{	
		Shot enemy = hitInfo.gameObject.GetComponent<Shot>();
		if (enemy != null)
		{					
			enemy.TakeDamage(10);

       Vector3 direction = (new Vector3(transform.position.x,hitInfo.transform.position.y,transform.position.z) - hitInfo.transform.position).normalized;

        hitInfo.gameObject.GetComponent<Rigidbody2D>().AddForce(-direction * 1000);


		}
	}






}
