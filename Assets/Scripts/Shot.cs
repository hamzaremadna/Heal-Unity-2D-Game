using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Shot : MonoBehaviour
{
	public static int maxHealth = 100;
	private int currentHealth;
	private Animator anim;
	public PauseMenu over;
	public TextMeshProUGUI numpotion;
	  public static int minus = 0;
		public HealthBar healthBar;
		private bool shot = false;
		private Rigidbody2D rb;
			public PlayerMovement pr;
			public AudioSource hit;
			public AudioSource dead;

	bool dmg = true;

	    private bool die = true;

	

    void Start()
    {
		   anim = GetComponent<Animator>();
		   		rb = GetComponent<Rigidbody2D>();
		   		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

    }

	public void Revive(){
       	   		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		die = true;
	}

	  void Update()
    {

				if(pr.shie()){
            dmg = false;
		}else{
			dmg = true;
		}
			if(shot){
				if(currentHealth > 0){
			anim.SetTrigger("hurt");
			hit.Play();	
		}else{
			if(die){
					pr.die();
			anim.SetTrigger("die");
			dead.Play();
			die = false;}
			    StartCoroutine(waiter());
		}
		shot = false; }
		
    }
public void potion(){
if(int.Parse(numpotion.text) > 0){
	       	   		currentHealth += 10;
		healthBar.SetHealth(currentHealth);
		PlayerPrefs.SetInt("minus", PlayerPrefs.GetInt("minus") + 1);
		}
}
public Vector2 a(){
return rb.position;
}
	IEnumerator waiter()
{    yield return new WaitForSeconds(1);
		over.Over();
	Time.timeScale = 0; 
}

	public void TakeDamage (int damage)
	{    if(dmg){  		
		shot = true;
		currentHealth -= damage;	 
		healthBar.SetHealth(currentHealth);}
	}


}
