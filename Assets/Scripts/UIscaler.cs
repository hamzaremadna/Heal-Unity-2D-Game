using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscaler : MonoBehaviour
{
    public float x;
    public float y;
     private CanvasScaler can;
    void Start()
    {
        can = GetComponent<CanvasScaler>();
        SetInfo();
    }

    // Update is called once per frame
    void SetInfo()
    { x = (float)Screen.currentResolution.width;
      y = (float)Screen.currentResolution.height;
      can.referenceResolution = new Vector2(x,y); 
        
    }

}
