using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
public CharacterController2D controller;
private Animator anim;
public Joystick joystick;  	
	public Power powerBar;
    public Shot health;

    public Transform firePoint;
	public GameObject bulletPrefab;
  public GameObject attack;
	private float currentForce;
    			public AudioSource shoot;



public float speed = 40f;
float horizontalMove = 0f;
float VerticalMove = 0f;
bool move = true;
bool power = false;
bool uppower = false;

	public static int maxForce = 500;
    public static float plus = 0.2f;
    public int ff;
    public float kk;

bool jump = false;
bool canjump = true;
bool eatv = false;


 
    void Start()
    {
   anim = GetComponent<Animator>();
         currentForce = maxForce;
   		powerBar.SetMaxPower(currentForce);
  
    }

	public void Shot()
	{
           
           if(move){
               if(currentForce >= 20){
    	   anim.SetTrigger("attack");
           currentForce -= 20;  
         powerBar.SetPower(currentForce);
         uppower=true;
           shoot.Play();
		Object obj = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Destroy(obj,1f);}}
	}

  /* public void eat(){
          
         anim.SetTrigger("eat");
         eatv = true;
     }*/
  public void revive(){
      anim.SetTrigger("revive");
      health.Revive();
      move = true;

  }
    	public void sheild()
	{
          anim.SetBool("shield",true);
        power = true;
       	move=false;
    }

      	public void unsheild()
	{     move = true;
         uppower = true;
         power = false;
          anim.SetBool("shield",false);
	}

    public void die(){
        move = false;
    }
    void Update()
    {      
          if(power)
            {   currentForce -= 1f;  
                powerBar.SetPower(currentForce);
                if(currentForce <= 0){
                    power = false;
                    unsheild();
                } 
                }

     if(uppower){
                    currentForce += plus;
                powerBar.SetPower(currentForce);
                if(currentForce >= maxForce){
                    uppower = false;
                }
            }   

     if(move){
    VerticalMove = joystick.Vertical;   
     horizontalMove = joystick.Horizontal * speed;  
     if(horizontalMove > 3f || horizontalMove < -3f){
                anim.SetBool("isMoving",true);}else{
                    horizontalMove = 0;
                anim.SetBool("isMoving",false);}

    if(canjump){
      if(VerticalMove > .3f ){
             jump = true;
     }           
    canjump = false;     
      StartCoroutine(waiter());

    }}else{horizontalMove = 0f;
    }

    }
    

	IEnumerator waiter()
{

    yield return new WaitForSeconds(0.57f);
    canjump = true;
   
}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("plateform"))
        {
            transform.parent = other.gameObject.transform;
        }
    }

        private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("plateform"))
        {
            transform.parent = null;
        }
    }
 
 /*	void OnCollisionEnter2D (Collision2D hitInfo)
	{	
        if(eatv){
		Shot enemy = hitInfo.gameObject.GetComponent<Shot>();
		if (enemy != null)
		{					
         Destroy(enemy);
        eatv = false;
		}else{eatv=false;}
}
	}*/
public bool shie(){
    return power;
}    
void FixedUpdate(){
controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
     jump = false;
           

}



}
