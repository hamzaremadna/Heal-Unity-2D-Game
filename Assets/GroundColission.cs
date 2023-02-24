using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColission : MonoBehaviour
{
    // Start is called before the first frame update
        	void OnCollisionEnter2D (Collision2D hitInfo)
	{	
		Shot enemy = hitInfo.gameObject.GetComponent<Shot>();
		if (enemy != null)
		{					
			enemy.TakeDamage(1500);



		}
	}
}
