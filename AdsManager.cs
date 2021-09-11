using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
#if UNITY_IOS
    string gameId = "4222816";
#else
    string gameId = "4222817";
#endif



    

    // Start is called before the first frame update
    void Start()
    {

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
        
    }


    // Update is called once per frame
    public void RewardedAd()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.Log("Rewarded ad is not ready");
        }
    }

        public void OnUnityAdsReady(string placementId)
        {
            Debug.Log("1");
        }

    public void OnUnityAdsDidStart(string placementId)
        {
            Debug.Log("2");
        }

    public void OnUnityAdsDidError(string message)
        {
            Debug.Log("3" + message);
        }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
            {
            szor.szorzo = 2;
                szor.szamlalo = szor.szamlalo + 300;
                Debug.Log("Végre");
                
            }
        }


}