using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabhealth : MonoBehaviour
{
     public GameObject obj;
     public Button but;
    void Update()
    {
     if(obj.activeSelf == true){
         but.Select();
     }  
    }
}
