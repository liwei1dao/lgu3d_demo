using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AdvTest_AdmobView_Comp : Model_BaseViewComp<AdvTestModule>
{
  private Text text;
  private Button OpenAd_Show_butt;
  private Button BannerAd_Show_butt;
  private Button InterstitialAd_Show_butt;
  private Button RewardedAd_Show_butt;
  private Button InterstitialRewardedAd_Show_butt;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "AdmobView");
    text = UIGameobject.OnSubmit<Text>("Scroll View/Viewport/Content/Text");
    OpenAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/OpenAd/Show");
    BannerAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/BannerAd/Show");
    InterstitialAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/InterstitialAd/Show");
    RewardedAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/RewardedAd/Show");
    InterstitialRewardedAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/InterstitialRewardedAd/Show");
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/Close", Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/OpenAd/Load", OpenAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/OpenAd/Show", OpenAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/OpenAd/Hide", OpenAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Load", BannerAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Show", BannerAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Hide", BannerAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Load", InterstitialAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Show", InterstitialAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Hide", InterstitialAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Load", RewardedAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Show", RewardedAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Hide", RewardedAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialRewardedAd/Load", InterstitialRewardedAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialRewardedAd/Show", InterstitialRewardedAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialRewardedAd/Hide", InterstitialRewardedAd_Hide);
    Hide();
    LoadEnd();
  }
  public override void Start(params object[] agr)
  {
    base.Start(agr);
    AdmobModule.Instance.logEvent = WriteLog;
  }
  public override void Show()
  {
    base.Show();
    updatebutt();
  }
  private void OpenAd_Load()
  {
    WriteLog("BannerAd_Load Click!");
    AdmobModule.Instance.OpenAd_Load((issucc) =>
    {
      WriteLog("OpenAd_Load:" + issucc.ToString());
      updatebutt();
    });
  }
  private void OpenAd_Show()
  {
    WriteLog("OpenAd_Show Click!");
    AdmobModule.Instance.OpenAd_Show();
  }
  private void OpenAd_Hide()
  {
    WriteLog("OpenAd_Hide Click!");
    AdmobModule.Instance.OpenAd_Hide();
  }
  private void BannerAd_Load()
  {
    WriteLog("BannerAd_Load Click!");
    AdmobModule.Instance.BannerAd_Load(AdPosition.Bottom, (issucc) =>
     {
       WriteLog("BannerAd_Load:" + issucc.ToString());
       updatebutt();
     });
  }
  private void BannerAd_Show()
  {
    WriteLog("BannerAd_Show Click!");
    AdmobModule.Instance.BannerAd_Show(AdPosition.Bottom);
  }
  private void BannerAd_Hide()
  {
    WriteLog("BannerAd_Hide Click!");
    AdmobModule.Instance.BannerAd_Hide();
  }
  private void InterstitialAd_Load()
  {
    WriteLog("InterstitialAd_Load Click!");
    AdmobModule.Instance.Intersitial_Load((issucc) =>
    {
      WriteLog("InterstitialAd_Load:" + issucc.ToString());
      updatebutt();
    });
  }
  private void InterstitialAd_Show()
  {
    WriteLog("InterstitialAd_Show Click!");
    AdmobModule.Instance.Intersitial_Show();
  }
  private void InterstitialAd_Hide()
  {
    WriteLog("InterstitialAd_Hide Click!");
    AdmobModule.Instance.Intersitial_Hide();
  }
  private void RewardedAd_Load()
  {
    WriteLog("RewardedAd_Load Click!");
    AdmobModule.Instance.Video_RewardedAd_Load((issucc) =>
    {
      WriteLog("RewardedAd_Load:" + issucc.ToString());
      updatebutt();
    });
  }
  private void RewardedAd_Show()
  {
    WriteLog("RewardedAd_Show Click!");
    AdmobModule.Instance.Video_RewardedAd_Show((issucc) =>
    {
      WriteLog("RewardedAd_Show:" + issucc.ToString());
      updatebutt();
    });
  }
  private void RewardedAd_Hide()
  {
    WriteLog("RewardedAd_Hide Click!");
    AdmobModule.Instance.Video_RewardedAd_Hide();
  }

  private void InterstitialRewardedAd_Load()
  {
    WriteLog("RewardedAd_Load Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Load((issucc) =>
    {
      WriteLog("RewardedAd_Load:" + issucc.ToString());
      updatebutt();
    });
  }
  private void InterstitialRewardedAd_Show()
  {
    WriteLog("RewardedAd_Show Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Show((issucc) =>
    {
      WriteLog("RewardedAd_Show:" + issucc.ToString());
      updatebutt();
    });
  }
  private void InterstitialRewardedAd_Hide()
  {
    WriteLog("RewardedAd_Hide Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Hide();
  }

  private void WriteLog(string msg)
  {
    text.text += msg + "\n";
  }

  private void updatebutt()
  {
    BannerAd_Show_butt.interactable = AdmobModule.Instance.BannerAd_IsReady();
    InterstitialAd_Show_butt.interactable = AdmobModule.Instance.Intersitial_IsReady();
    RewardedAd_Show_butt.interactable = AdmobModule.Instance.Video_RewardedAd_IsReady();
  }
}