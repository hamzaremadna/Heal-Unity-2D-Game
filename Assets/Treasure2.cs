using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure2 : MonoBehaviour
{
    private Animator anim;
   public AudioSource q;
   public GameObject a;
    bool k = true;

     void Start()
    {
       anim = GetComponent<Animator>();  
    }

     
   	void OnTriggerEnter2D (Collider2D hitInfo)
	{	 
    Shot enemy = hitInfo.GetComponent<Shot>();
		if (enemy != null)
		{	
    if(k){
       if(PlayerPrefs.GetString("trsr2") == ""){
         PlayerPrefs.SetString("trsr2","yes");
         q.Play();
          anim.SetTrigger("a");
       }else{
                 Destroy(a);
           anim.SetTrigger("a");

       }
       k = false;
       }
	}}
}
