using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CloudOnce;

public class ScoreManager : MonoBehaviour
{
    void Start()
    {   Cloud.OnInitializeComplete += CloudOnceInitializeComplete; 
        Cloud.Initialize(false,true);
    }

    // Update is called once per frame
 public void CloudOnceInitializeComplete()
    {
        Cloud.OnInitializeComplete -= CloudOnceInitializeComplete; 
        Debug.LogWarning("Initialize");
    }

    public void Update(){
        if(PlayerShot.score==5){
            if(!Achievements.NotBad.IsUnlocked){
            Achievements.NotBad.Unlock();
                    Debug.LogWarning("Beginner");}
        }
           if(PlayerShot.score==15){
                           if(!Achievements.ThatsOnlytheBeginning.IsUnlocked){
            Achievements.ThatsOnlytheBeginning.Unlock();
                    Debug.LogWarning("Expert");}
        }
               if(PlayerShot.score==30){
                               if(!Achievements.KillthemAll.IsUnlocked){

            Achievements.KillthemAll.Unlock();
                    Debug.LogWarning("Expert");}
        }
    }
}
