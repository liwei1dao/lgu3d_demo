using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AdvTest_VungleView_Comp : Model_BaseViewComp<AdvTestModule>
{
  private Text text;
  private Button BannerAd_Show_butt;
  private Button InterstitialAd_Show_butt;
  private Button RewardedAd_Show_butt;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "VungleView");
    text = UIGameobject.OnSubmit<Text>("Scroll View/Viewport/Content/Text");
    BannerAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/BannerAd/Show");
    InterstitialAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/InterstitialAd/Show");
    RewardedAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/RewardedAd/Show");
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/Close", Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Load", BannerAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Show", BannerAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/BannerAd/Hide", BannerAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Load", InterstitialAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Show", InterstitialAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/InterstitialAd/Hide", InterstitialAd_Hide);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Load", RewardedAd_Load);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Show", RewardedAd_Show);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/RewardedAd/Hide", RewardedAd_Hide);
    Hide();
    LoadEnd();
  }

  public override void Start(params object[] agr)
  {
    base.Start(agr);
    VungleAdvModule.Instance.logEvent = WriteLog;
  }
  public override void Show()
  {
    base.Show();
    updatebutt();
  }
  private void BannerAd_Load()
  {
    WriteLog("BannerAd_Load Click!");
    VungleAdvModule.Instance.BannerAd_Load(AdPosition.Bottom, (issucc) =>
     {
       updatebutt();
     });
  }
  private void BannerAd_Show()
  {
    WriteLog("BannerAd_Show Click!");
    VungleAdvModule.Instance.BannerAd_Show(AdPosition.Bottom);
  }
  private void BannerAd_Hide()
  {
    WriteLog("BannerAd_Hide Click!");
    VungleAdvModule.Instance.BannerAd_Hide();
  }
  private void InterstitialAd_Load()
  {
    WriteLog("InterstitialAd_Load Click!");
    VungleAdvModule.Instance.Intersitial_Load((issucc) =>
    {
      updatebutt();
    });
  }
  private void InterstitialAd_Show()
  {
    WriteLog("InterstitialAd_Show Click!");
    VungleAdvModule.Instance.Intersitial_Show();
  }
  private void InterstitialAd_Hide()
  {
    WriteLog("InterstitialAd_Hide Click!");
    VungleAdvModule.Instance.Intersitial_Hide();
  }
  private void RewardedAd_Load()
  {
    WriteLog("RewardedAd_Load Click!");
    VungleAdvModule.Instance.Video_RewardedAd_Load((issucc) =>
    {
      updatebutt();
    });
  }
  private void RewardedAd_Show()
  {
    WriteLog("RewardedAd_Show Click!");
    VungleAdvModule.Instance.Video_RewardedAd_Show((issucc) =>
    {
      Debug.Log("RewardedAd:" + issucc.ToString());
    });
  }
  private void RewardedAd_Hide()
  {
    WriteLog("RewardedAd_Hide Click!");
    VungleAdvModule.Instance.Video_RewardedAd_Hide();
  }
  private void WriteLog(string msg)
  {
    text.text += msg + "\n";

  }
  private void updatebutt()
  {
    BannerAd_Show_butt.interactable = VungleAdvModule.Instance.BannerAd_IsReady();
    InterstitialAd_Show_butt.interactable = VungleAdvModule.Instance.Intersitial_IsReady();
    RewardedAd_Show_butt.interactable = VungleAdvModule.Instance.Video_RewardedAd_IsReady();
  }
}