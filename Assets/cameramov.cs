using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramov : MonoBehaviour
{
private bool a = false; 
private bool b = false;  
    Vector2 target;
    Vector2 target2;

      public void Start(){
                 target = new Vector2(-800, transform.position.y);
          target2 = new Vector2(800, transform.position.y);

      }
    public void move()
    {   b = false;   
        a = true;

      }
      public void unmove(){
          a = false;
          b = true;
      }
      public void Update(){
          if(a){
		transform.position = Vector2.Lerp(transform.position, target, 1f * Time.fixedDeltaTime);}	   
          else{if(b){
		transform.position = Vector2.Lerp(transform.position,target2, 1f * Time.fixedDeltaTime);}}	   
      }
}
