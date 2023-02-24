using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{ 
    public AudioMixer audioMixer;
    public AudioMixer audioMixer2;

   public void SetVolume(float volume){
       audioMixer.SetFloat("volume",volume); 
   } 
     public void SetVolume2(float volume){
       audioMixer2.SetFloat("volume",volume); 
   }  
}
