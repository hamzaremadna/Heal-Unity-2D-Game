using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
        public GameObject gameobject;
            GameObject obj;
        void Awake(){
             obj = gameobject.GetComponent<GameObject>();
        }
   public void setactive(){

       obj.SetActive(false);
   }
}
