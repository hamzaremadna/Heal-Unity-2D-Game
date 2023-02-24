using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
private Animator anim;
	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		   anim = GetComponent<Animator>();

		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			    	   anim.SetTrigger("hurt");
			TakeDamage(20);

		}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
