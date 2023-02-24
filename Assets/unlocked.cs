using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlocked : MonoBehaviour
{

      public Button but;
      public string a;
    void Start()
    {
        if(PlayerPrefs.GetString(a) == "yes" ){
            Destroy(gameObject);
            but.interactable = true;
        }else but.interactable = false;
        
    }


}
