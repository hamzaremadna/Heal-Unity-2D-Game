using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
	public GameObject bulletPrefab;
	private Animator anim;
void Start()
    {
   anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
	   anim.SetTrigger("attack");
			Shoot();
		}
	}

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
