using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class loaddata : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
   public int potion;
   public int moreenergy;
  public int fasterenergy;
  public TextMeshProUGUI potionnum;


    void Start()
    {
        LoadPlayer();
        funchealth(health);
        funcfast(fasterenergy);
        funcmore(moreenergy);
    }

     public void potionmin(){
         if(potion > 0){
           potion -= 1; 
           potionnum.text =  potion.ToString();
           }
     }

     public void funchealth(int a){
        Shot.maxHealth += a;
     }
     public void funcfast(int a){

          PlayerMovement.plus += 0.04f * a;
     }

     public void funcmore(int a){
           
          PlayerMovement.maxForce += 100 * a;

     }


        public void LoadPlayer()
    {
             string path =  Application.persistentDataPath + "/player.cc";
                if(File.Exists(path)){
                    PlayerData data = SaveSystem.Load();

               health = data.health[1];    
                 potion = data.potion[1]; 
                         potion -= PlayerPrefs.GetInt("minus");
                 moreenergy = data.moreenergy[1]; 
                 fasterenergy  = data.fasterenergy[1];
                 potionnum.text =  potion.ToString();
              }

    }
}
