using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youwin : MonoBehaviour
{
    public GameObject gameObject;
    	void OnTriggerEnter2D (Collider2D hitInfo)
	{	 
         Shot enemy = hitInfo.GetComponent<Shot>();
         	if (enemy != null)
		{	
       gameObject.SetActive(true);
   	Time.timeScale = 0;
}
    }
}
