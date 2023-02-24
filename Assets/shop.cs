using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class shop : MonoBehaviour
{
       public int coins;
   public int[] health = new int[2];
   public int[] potion = new int[2];
   public int[] moreenergy = new int[2];
  public int[] fasterenergy = new int[2];
    public TextMeshProUGUI coinscount;  
    public AudioSource a;
public TextMeshProUGUI healthprice;
public TextMeshProUGUI healthlevel;
public TextMeshProUGUI potionprice;
public TextMeshProUGUI potionnum;
public TextMeshProUGUI fasterenergyprice;
public TextMeshProUGUI fasterenergylevel;
public TextMeshProUGUI moreenergyprice;
public TextMeshProUGUI moreenergylevel;

void Start(){ 
    LoadPlayer(); 
    
    if(PlayerPrefs.GetInt("minus") > 0){
usedpotion();
    }

       if(PlayerPrefs.GetString("trsr3") == "yes" ){
                               treasurefound2();
                               PlayerPrefs.SetString("trsr3","no"); }
       if(PlayerPrefs.GetString("trsr2") == "yes" ){
                               treasurefound();
                               PlayerPrefs.SetString("trsr2","no"); }
        if(PlayerPrefs.GetString("trsr") == "yes" ){
                               treasurefound();
                               PlayerPrefs.SetString("trsr","no"); }
         

}


    public void buylevelhealth(){
              coins = int.Parse(coinscount.text);
                    if(coins >= health[0]){
           if(health[0] != 3200)  {
               a.Play();
                             coins -= int.Parse(healthprice.text);
                  coinscount.text = coins.ToString();
        health[0] = int.Parse(healthprice.text) + 300;
        health[1] = int.Parse(healthlevel.text) + 100;
        healthprice.text = health[0].ToString();
        healthlevel.text = health[1].ToString();
        SavePlayer();}}

    }
        public void buypotionhealth(){
            coins = int.Parse(coinscount.text);
                    if(coins >= potion[0]){
                                       a.Play();

                 coins -= int.Parse(potionprice.text);
                  coinscount.text = coins.ToString();
               potion[1] = int.Parse(potionnum.text) + 1;
                potionnum.text = potion[1].ToString();
                SavePlayer();} 
    }
 

    

        public void buyfasterenergy(){
            coins = int.Parse(coinscount.text);
                    if(coins >= fasterenergy[0]){
              if(fasterenergy[0] != 3200){  
                                 a.Play();

                  coins -= int.Parse(fasterenergyprice.text);
                  coinscount.text = coins.ToString();
              fasterenergy[0] = int.Parse(fasterenergyprice.text) + 300;
                fasterenergy[1] = int.Parse(fasterenergylevel.text) + 1;
              
                fasterenergyprice.text = fasterenergy[0].ToString();
                 fasterenergylevel.text = fasterenergy[1].ToString();
                         SavePlayer();}}
    }

    public void dailyreward(){
       coins = int.Parse(coinscount.text) + 200;
       coinscount.text = coins.ToString();
               SavePlayer();

    }
public void dailyrewardad(){
         coins = int.Parse(coinscount.text) + 400;
       coinscount.text = coins.ToString();
               SavePlayer();

}
   public void usedpotion(){
       potion[1] -= PlayerPrefs.GetInt("minus");
      potionnum.text = potion[1].ToString();
      PlayerPrefs.SetInt("minus",0);
        SavePlayer();
            LoadPlayer();
    }
      public void treasurefound(){                
       coins += 1000;
      coinscount.text = coins.ToString();
        SavePlayer();
            LoadPlayer();
    }
          public void treasurefound2(){        
       coins += 3000;
      coinscount.text = coins.ToString();
        SavePlayer();
            LoadPlayer();

    }
        public void buymoreenergy(){
            coins = int.Parse(coinscount.text);
                    if(coins >= moreenergy[0]){
            if(moreenergy[0]!= 3200){
                               a.Play();
                              coins -= int.Parse(moreenergyprice.text);
                  coinscount.text = coins.ToString();
         moreenergy[0] = int.Parse(moreenergyprice.text) + 300;
         moreenergy[1] = int.Parse(moreenergylevel.text) + 1;
                moreenergyprice.text = moreenergy[0].ToString();
                 moreenergylevel.text = moreenergy[1].ToString();
          SavePlayer();}}
    }


    public void SavePlayer()
    {
        SaveSystem.Save(this);
    }

    public void LoadPlayer()
    {
             string path =  Application.persistentDataPath + "/player.cc";
                if(File.Exists(path)){
                    PlayerData data = SaveSystem.Load();
               coins = data.coins;
              health[0] = data.health[0]; 
               health[1] = data.health[1];    
                potion[0] = data.potion[0];  
                 potion[1] = data.potion[1]; 
                 moreenergy[0] = data.moreenergy[0]; 
                 moreenergy[1] = data.moreenergy[1]; 
                 fasterenergy[0] = data.fasterenergy[0]; 
                 fasterenergy[1] = data.fasterenergy[1];
                 coinscount.text = coins.ToString();
                 healthprice.text = health[0].ToString();
                 healthlevel.text = health[1].ToString();
                 potionnum.text =  potion[1].ToString();
                 potionprice.text = potion[0].ToString();
                  moreenergyprice.text = moreenergy[0].ToString();
                 moreenergylevel.text = moreenergy[1].ToString();
                  fasterenergyprice.text = fasterenergy[0].ToString();
                 fasterenergylevel.text = fasterenergy[1].ToString(); }

    }
}
