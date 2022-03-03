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
    AdmobModule.Instance.LoadEvent += AdvLoad;
    AdmobModule.Instance.RewardEvent += AdvReward;
  }

  private void AdvLoad(AdvType atype,bool isload){
    WriteLog(string.Format("AdvTest_AdmobView_Comp AdvLoad AdvType:{0} isload:{1}",atype.ToString(),isload.ToString()));
    updatebutt();
  }
  private void AdvReward(AdvType atype,bool isload){
    WriteLog(string.Format("AdvTest_AdmobView_Comp AdvReward AdvType:{0} isload:{1}",atype.ToString(),isload.ToString()));
    updatebutt();
  }

  public override void Show()
  {
    base.Show();
    updatebutt();
  }
  private void OpenAd_Load()
  {
    WriteLog("AdvTest_AdmobView_Comp BannerAd_Load Click!");
    AdmobModule.Instance.OpenAd_Load();
  }
  private void OpenAd_Show()
  {
    WriteLog("AdvTest_AdmobView_Comp OpenAd_Show Click!");
    AdmobModule.Instance.OpenAd_Show();
  }
  private void OpenAd_Hide()
  {
    WriteLog("AdvTest_AdmobView_Comp OpenAd_Hide Click!");
    AdmobModule.Instance.OpenAd_Hide();
  }
  private void BannerAd_Load()
  {
    WriteLog("AdvTest_AdmobView_Comp BannerAd_Load Click!");
    AdmobModule.Instance.BannerAd_Load(AdPosition.Bottom);
  }
  private void BannerAd_Show()
  {
    WriteLog("AdvTest_AdmobView_Comp BannerAd_Show Click!");
    AdmobModule.Instance.BannerAd_Show(AdPosition.Bottom);
  }
  private void BannerAd_Hide()
  {
    WriteLog("AdvTest_AdmobView_Comp BannerAd_Hide Click!");
    AdmobModule.Instance.BannerAd_Hide();
  }
  private void InterstitialAd_Load()
  {
    WriteLog("AdvTest_AdmobView_Comp InterstitialAd_Load Click!");
    AdmobModule.Instance.Intersitial_Load();
  }
  private void InterstitialAd_Show()
  {
    WriteLog("AdvTest_AdmobView_Comp InterstitialAd_Show Click!");
    AdmobModule.Instance.Intersitial_Show();
  }
  private void InterstitialAd_Hide()
  {
    WriteLog("AdvTest_AdmobView_Comp InterstitialAd_Hide Click!");
    AdmobModule.Instance.Intersitial_Hide();
  }
  private void RewardedAd_Load()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Load Click!");
    AdmobModule.Instance.Video_RewardedAd_Load();
  }
  private void RewardedAd_Show()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Show Click!");
    AdmobModule.Instance.Video_RewardedAd_Show();
  }
  private void RewardedAd_Hide()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Hide Click!");
    AdmobModule.Instance.Video_RewardedAd_Hide();
  }

  private void InterstitialRewardedAd_Load()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Load Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Load();
  }
  private void InterstitialRewardedAd_Show()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Show Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Show();
  }
  private void InterstitialRewardedAd_Hide()
  {
    WriteLog("AdvTest_AdmobView_Comp RewardedAd_Hide Click!");
    AdmobModule.Instance.Interstitial_RewardedAd_Hide();
  }

  private void WriteLog(string msg)
  {
    text.text += msg + "\n";
  }

  private void updatebutt()
  {
    OpenAd_Show_butt.interactable = AdmobModule.Instance.OpenAd_IsReady();
    BannerAd_Show_butt.interactable = AdmobModule.Instance.BannerAd_IsReady();
    InterstitialAd_Show_butt.interactable = AdmobModule.Instance.Intersitial_IsReady();
    RewardedAd_Show_butt.interactable = AdmobModule.Instance.Video_RewardedAd_IsReady();
    InterstitialRewardedAd_Show_butt.interactable = AdmobModule.Instance.Interstitial_RewardedAd_IsReady();
  }
}