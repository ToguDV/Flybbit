using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsController : MonoBehaviour
{
    public string appID = "";
    public string bannerID = "";
 
    private BannerView bannerView;
    

    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });





       
        
       
    }

    private void OnMouseDown()
    {
        RequestBanner();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void RequestBanner()
    {

        string adUnitId = "ca-app-pub-3940256099942544/6300978111";

        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

        

   
}
