using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcollison : MonoBehaviour
{ 
     bool a = true;
     public GameObject win;

    	void OnTriggerEnter2D (Collider2D other)
	{	 
        if (other.gameObject.CompareTag("Player"))
        {
            if(a){
                Destroy(other.gameObject);
              GetComponent<Animator>().SetTrigger("a");
                 win.SetActive(true);
              a=false;}
        }
    }   
}
