using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;
    public int[] health;
    public int[] potion; 
    public int[] moreenergy;
    public int[] fasterenergy;
    


     public PlayerData(shop player){
        coins = player.coins;
        health = new int[2];
        health[0] = player.health[0];
        health[1]= player.health[1];
         potion = new int[2];
        potion[0] = player.potion[0];
        potion[1]= player.potion[1];
         moreenergy = new int[2];
        moreenergy[0] = player.moreenergy[0];
        moreenergy[1] = player.moreenergy[1];
         fasterenergy = new int[2];
        fasterenergy[0] = player.fasterenergy[0];
        fasterenergy[1]= player.fasterenergy[1];
     }





 
}
