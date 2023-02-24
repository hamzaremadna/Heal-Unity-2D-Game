using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
	 public GameObject wl;
     		Animator anim;

    void Start()
    {
        	anim = wl.GetComponent<Animator>(); 

        
    }

    // Update is called once per frame
    public void open()
    {
      anim.SetTrigger("a");
      
    }
}
