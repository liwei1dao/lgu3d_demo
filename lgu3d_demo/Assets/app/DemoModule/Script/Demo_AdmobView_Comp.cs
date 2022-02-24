using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Demo_AdmobView_Comp : Model_BaseViewComp<DemoModule>
{
  private Button Admob;
  private Button Vungle;
  private Button Unity;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "AdmobView");
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/Close", Hide);
    Hide();
    LoadEnd();
  }
  public override void Start(params object[] agr)
  {
    base.Start(agr);
    // Manager_ManagerModel.Instance.StartModule<AdmobModule>(null, new Dictionary<AdvType, string>()
    //     {
    // #if UNITY_EDITOR || ADVTEST
    //       { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
    //       { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
    //       { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
    //       { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
    //       { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
    // #elif UNITY_ANDROID
    //       { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
    //       { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
    //       { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
    //       { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
    //       { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
    // #elif UNITY_IPHONE
    //       { AdvType.AppOpenAd, "ca-app-pub-3940256099942544/3419835294" },
    //       { AdvType.BannerAd, "ca-app-pub-3940256099942544/6300978111" },
    //       { AdvType.IntersitialAd, "ca-app-pub-3940256099942544/1033173712" },
    //       { AdvType.Video_RewardedAd, "ca-app-pub-3940256099942544/5224354917" },
    //       { AdvType.IntersitialAd_RewardedAd, "ca-app-pub-3940256099942544/5354046379" },
    // #endif
    // });
  }
}