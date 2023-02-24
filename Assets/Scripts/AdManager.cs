using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class AdManager : MonoBehaviour
{

   public static AdManager instance;
   private string appID = "ca-app-pub-2457987159820161~7162631658";
    private RewardedAd rewardedad;
    bool u = false;
    bool k = false;
    public Button button;
    public Button button2;
   public void Awake()
   { if(instance == null){
       instance = this;
   }else{
       Destroy(this);
   }
   } 
   private void Start(){
        MobileAds.Initialize(initStatus => { });
     string adid = "ca-app-pub-3940256099942544/5224354917";
        //  string adid = "ca-app-pub-2457987159820161/5466406607";
       this.rewardedad = new RewardedAd(adid);
          this.rewardedad.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedad.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedad.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedad.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedad.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedad.OnAdClosed += HandleRewardedAdClosed;   
        requestad();
         }      



   public void requestad(){
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedad.LoadAd(request);
    }
   public void showad()
   {
       if(rewardedad.IsLoaded()){
           this.rewardedad.Show();
       }else{
           Debug.Log("Error");
       }
}

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");


    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);

    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
       requestad();
       if(u==false){
        k = true;}
         


    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        u = true;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }

    void Update(){
        if(u){
              button.onClick.Invoke();
              u = false;
              }
              if(k){
              button2.onClick.Invoke();
              k = false;
              }
              }
    
}
