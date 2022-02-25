using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AdvTest_AdvManager_Comp : Module_AdvManager_Comp<AdvTestModule>
{

  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, agrs);
    #region AdmobModule
    Manager_ManagerModel.Instance.StartModule<AdmobModule>((module) =>
    {
      module.Initialize((isucc) =>
      {
        Debug.Log("Start AdmobModule:" + isucc.ToString());
        advs.Add(AdmobModule.Instance);
      });
    }, new Dictionary<AdvType, string>()
        {
          #if UNITY_EDITOR || ADVTEST
                { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
                { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
                { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
                { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
          #elif UNITY_ANDROID
                { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
                { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
                { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
                { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
          #elif UNITY_IPHONE
                { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
                { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
                { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
                { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
          #endif
    });
    #endregion
    #region VungleAdvModule
    Manager_ManagerModel.Instance.StartModule<VungleAdvModule>((module) =>
    {
      module.Initialize("5e15c0585ec4860017a38f46", true, (isucc) =>
      {
        Debug.Log("Start VungleAdvModule:" + isucc.ToString());
        advs.Add(VungleAdvModule.Instance);
      });
    }, new Dictionary<AdvType, string>()
        {
        #if UNITY_EDITOR || ADVTEST
              { AdvType.AppOpenAd, ""},
              { AdvType.BannerAd, "ADS004-8413128" },
              { AdvType.IntersitialAd, "DEFAULT-5670107" },
              { AdvType.Video_RewardedAd, "ADS02-3599132" },
              { AdvType.IntersitialAd_RewardedAd, "" },
        #elif UNITY_ANDROID
              { AdvType.AppOpenAd, ""},
              { AdvType.BannerAd, "ADS004-8413128" },
              { AdvType.IntersitialAd, "DEFAULT-5670107" },
              { AdvType.Video_RewardedAd, "ADS02-3599132" },
              { AdvType.IntersitialAd_RewardedAd, "" },
        #elif UNITY_IPHONE
              { AdvType.AppOpenAd, ""},
              { AdvType.BannerAd, "ADS004-8413128" },
              { AdvType.IntersitialAd, "DEFAULT-5670107" },
              { AdvType.Video_RewardedAd, "ADS02-3599132" },
              { AdvType.IntersitialAd_RewardedAd, "" },
        #endif
    });
    #endregion
    #region UnityAdsModule
    Manager_ManagerModel.Instance.StartModule<UnityAdsModule>((module) =>
    {
      module.Initialize("4628697", true, (isucc) =>
      {
        Debug.Log("Start UnityAdsModule:" + isucc.ToString());
        advs.Add(UnityAdsModule.Instance);
      });
    }, new Dictionary<AdvType, string>()
        {
      #if UNITY_EDITOR || ADVTEST
            { AdvType.AppOpenAd, ""},
            { AdvType.BannerAd, "Banner_Android" },
            { AdvType.IntersitialAd, "Interstitial_Android" },
            { AdvType.Video_RewardedAd, "Rewarded_Android" },
            { AdvType.IntersitialAd_RewardedAd, "" },
  #elif UNITY_ANDROID
            { AdvType.AppOpenAd, ""},
            { AdvType.BannerAd, "Banner_Android" },
            { AdvType.IntersitialAd, "Interstitial_Android" },
            { AdvType.Video_RewardedAd, "Rewarded_Android" },
            { AdvType.IntersitialAd_RewardedAd, "" },
  #elif UNITY_IPHONE
            { AdvType.AppOpenAd, ""},
            { AdvType.BannerAd, "Banner_Android" },
            { AdvType.IntersitialAd, "Interstitial_Android" },
            { AdvType.Video_RewardedAd, "Rewarded_Android" },
            { AdvType.IntersitialAd_RewardedAd, "" },
  #endif
    });
    #endregion
    LoadEnd();
  }
}