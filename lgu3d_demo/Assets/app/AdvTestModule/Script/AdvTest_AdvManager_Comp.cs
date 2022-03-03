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
      module.Weights = AdvvWeights.VeryHigh;
      module.InitializationEvent += AdvInitialization;
      module.Initialize();
    }, new Dictionary<AdvType, string>()
        {
          #if UNITY_EDITOR || ADVTEST
                { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
                { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
                { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
                { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
          #elif UNITY_ANDROID
                { AdvType.AppOpenAd, "ca-app-pub-6728799546168383/3374133645"},
                { AdvType.BannerAd, "ca-app-pub-6728799546168383/2499858061" },
                { AdvType.IntersitialAd, "ca-app-pub-6728799546168383/7313378656" },
                { AdvType.Video_RewardedAd, "ca-app-pub-6728799546168383/8243139337" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-6728799546168383/5397484143" },
          #elif UNITY_IPHONE
                { AdvType.AppOpenAd, "ca-app-pub-6728799546168383/3038125754" },
                { AdvType.BannerAd, "ca-app-pub-6728799546168383/8283887035" },
                { AdvType.IntersitialAd, "ca-app-pub-6728799546168383/2846554060" },
                { AdvType.Video_RewardedAd, "ca-app-pub-6728799546168383/9220390729" },
                { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-6728799546168383/2422851963" },
          #endif
    });
    #endregion
    #region VungleAdvModule
    Manager_ManagerModel.Instance.StartModule<VungleAdvModule>((module) =>
    {
      module.Weights = AdvvWeights.Medium;
      module.InitializationEvent += AdvInitialization;
      module.Initialize("5e15c0585ec4860017a38f46", true);
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
      module.Weights = AdvvWeights.High;
      module.InitializationEvent += AdvInitialization;
      module.Initialize("4628697", true);
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