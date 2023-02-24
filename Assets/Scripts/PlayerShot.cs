using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    // Start is called before the first frame update
	public int maxHealth = 100;
    public AudioSource a;
	private int currentHealth;
		public GameObject destroy;
		public static int score;
		Animator anim;
		public wall i;



    void Start()
    {
		        
		   		currentHealth = maxHealth;

    }

	  void Update()
    {

				
          if(currentHealth < 0){

			  						a.Play();
									  Destroy(gameObject); 
									  score += 1;
			  Object obj = Instantiate(destroy, GetComponent<Rigidbody2D>().position,Quaternion.identity);
			  Destroy(obj,2f);			     
			               i.open();


}


    }


	public void TakeDamage (int damage)
	{   
		currentHealth -= damage;	

	}


}
