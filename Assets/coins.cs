using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coins : MonoBehaviour
{
      public TextMeshProUGUI coinsnumber;
      public static int coinscount = 100;

       void Start()
    {
        coinsnumber.text = coinscount.ToString();
    }

    // Update is called once per frame
    public void shop(int n)
    {
        coinscount -= n;
                coinsnumber.text = coinscount.ToString();
    }

     public void gain(int g)
    {
        coinscount -= g;
                coinsnumber.text = coinscount.ToString();

    }
}
