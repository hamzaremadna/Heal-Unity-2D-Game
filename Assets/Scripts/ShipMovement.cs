using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipMovement : MonoBehaviour
{
public ShipController controller;
public Joystick joystick;
    public Transform firePoint;
	public GameObject bulletPrefab;
  public GameObject attack;
  public Rigidbody2D rb;





public float speed = 20f;
float horizontalMove = 0f;
float VerticalMove = 0f;

bool jump = false;







    void Update()
    {
     horizontalMove = joystick.Horizontal * speed;  
   
     VerticalMove = joystick.Vertical * 40f; 

    }


	public void Shot()
	{
        		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
    
void FixedUpdate(){
rb.position = new Vector3 (rb.position.x + horizontalMove * Time.fixedDeltaTime, rb.position.y + VerticalMove * Time.fixedDeltaTime, 0);
           

}



}
