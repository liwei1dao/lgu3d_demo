using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using lgu3d;

public class main : Main
{
  protected override void StartApp()
  {
    Manager_ManagerModel.Instance.StartModule<AdmobModule>(null, new Dictionary<AdvType, string>()
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
    Manager_ManagerModel.Instance.StartModule<VungleAdvModule>(null, "5e15c0585ec4860017a38f46", new Dictionary<AdvType, string>()
        {
    #if UNITY_EDITOR || ADVTEST
          { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
          { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
          { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
          { AdvType.Video_RewardedAd, "ADS02-3599132" },
          { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
    #elif UNITY_ANDROID
          { AdvType.AppOpenAd, "ca-app-pub-6728799546168383/3374133645"},
          { AdvType.BannerAd, "ADS004-8413128" },
          { AdvType.IntersitialAd, "DEFAULT-5670107" },
          { AdvType.Video_RewardedAd, "ADS02-3599132" },
          { AdvType.IntersitialAd_RewardedAd, "" },
    #elif UNITY_IPHONE
          { AdvType.AppOpenAd, "ca-app-pub-6728799546168383/3038125754" },
          { AdvType.BannerAd, "ca-app-pub-6728799546168383/8283887035" },
          { AdvType.IntersitialAd, "ca-app-pub-6728799546168383/2846554060" },
          { AdvType.Video_RewardedAd, "ca-app-pub-6728799546168383/9220390729" },
          { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-6728799546168383/2422851963" },
    #endif
    });
    Manager_ManagerModel.Instance.StartModule<ViewManagerModule>((module) =>
    {
      Manager_ManagerModel.Instance.StartModule<ResourceModule>((module) =>
      {
        Manager_ManagerModel.Instance.StartModule<TimerModule>();
        Manager_ManagerModel.Instance.StartModule<CoroutineModule>();
        Manager_ManagerModel.Instance.StartModule<EventModule>();
        Manager_ManagerModel.Instance.StartModule<SoundModule>();
        Manager_ManagerModel.Instance.StartModule<LanguageModule>(null, LanguageType.EN);
        Manager_ManagerModel.Instance.StartModule<SceneModule>();
        Manager_ManagerModel.Instance.StartModule<CommonModule>();
        Manager_ManagerModel.Instance.StartModule<DemoModule>();
      }, new ResLoadViewComp());
    }, new Vector2(1080, 1920), 0f);
  }
}
