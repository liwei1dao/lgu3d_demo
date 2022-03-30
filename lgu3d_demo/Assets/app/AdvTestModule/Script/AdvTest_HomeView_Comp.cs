using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AdvTest_HomeView_Comp : Model_BaseViewComp<AdvTestModule>
{
  private Text text;
  private Button OpenAd_Show_butt;
  private Button BannerAd_Show_butt;
  private Button InterstitialAd_Show_butt;
  private Button RewardedAd_Show_butt;
  private Button InterstitialRewardedAd_Show_butt;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "HomeView");
    text = UIGameobject.OnSubmit<Text>("Scroll View/Viewport/Content/Text");
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/admob", AdmobClick);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/vungle", VungleClick);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/unity", UnityClick);
    OpenAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/OpenAd/Show");
    BannerAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/BannerAd/Show");
    InterstitialAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/InterstitialAd/Show");
    RewardedAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/RewardedAd/Show");
    InterstitialRewardedAd_Show_butt = UIGameobject.OnSubmit<Button>("Scroll View/Viewport/Content/InterstitialRewardedAd/Show");
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

  private void AdmobClick()
  {
    MyModule.AdmobView_Comp.Show();
  }
  private void VungleClick()
  {
    MyModule.VungleView_Comp.Show();
  }
  private void UnityClick()
  {
    MyModule.UnityView_Comp.Show();
  }

  private void OpenAd_Load()
  {
    WriteLog("BannerAd_Load Click!");
    MyModule.AdvManager_Comp.LoadAdv(AdvType.AppOpenAd, AdPosition.Bottom);
  }
  private void OpenAd_Show()
  {
    WriteLog("OpenAd_Show Click!");
    MyModule.AdvManager_Comp.ShowAdv(AdvType.AppOpenAd);
  }
  private void OpenAd_Hide()
  {
    WriteLog("OpenAd_Hide Click!");
    MyModule.AdvManager_Comp.HideAdv(AdvType.AppOpenAd);
  }
  private void BannerAd_Load()
  {
    WriteLog("BannerAd_Load Click!");
    MyModule.AdvManager_Comp.LoadAdv(AdvType.BannerAd, AdPosition.Bottom);
  }
  private void BannerAd_Show()
  {
    WriteLog("BannerAd_Show Click!");
    MyModule.AdvManager_Comp.ShowBanner(AdPosition.Bottom);
  }
  private void BannerAd_Hide()
  {
    WriteLog("BannerAd_Hide Click!");
    MyModule.AdvManager_Comp.HideAdv(AdvType.BannerAd);
  }
  private void InterstitialAd_Load()
  {
    WriteLog("InterstitialAd_Load Click!");
    MyModule.AdvManager_Comp.LoadAdv(AdvType.IntersitialAd, AdPosition.Bottom);
  }
  private void InterstitialAd_Show()
  {
    WriteLog("InterstitialAd_Show Click!");
    MyModule.AdvManager_Comp.ShowAdv(AdvType.IntersitialAd);
  }
  private void InterstitialAd_Hide()
  {
    WriteLog("InterstitialAd_Hide Click!");
    MyModule.AdvManager_Comp.HideAdv(AdvType.IntersitialAd);
  }
  private void RewardedAd_Load()
  {
    WriteLog("RewardedAd_Load Click!");
    MyModule.AdvManager_Comp.LoadAdv(AdvType.Video_RewardedAd, AdPosition.Bottom);
  }
  private void RewardedAd_Show()
  {
    WriteLog("RewardedAd_Show Click!");
    MyModule.AdvManager_Comp.ShowRewardedAdv(AdvType.Video_RewardedAd, (advtype, succ) => { });
  }
  private void RewardedAd_Hide()
  {
    WriteLog("RewardedAd_Hide Click!");
    MyModule.AdvManager_Comp.HideAdv(AdvType.Video_RewardedAd);
  }

  private void InterstitialRewardedAd_Load()
  {
    WriteLog("InterstitialRewardedAd_Load Click!");
    MyModule.AdvManager_Comp.LoadAdv(AdvType.IntersitialAd_RewardedAd, AdPosition.Bottom);
  }
  private void InterstitialRewardedAd_Show()
  {
    WriteLog("InterstitialRewardedAd_Show Click!");
    MyModule.AdvManager_Comp.ShowRewardedAdv(AdvType.IntersitialAd_RewardedAd, (advtype, issucc) =>
     {
       WriteLog("InterstitialRewardedAd_Show:" + issucc.ToString());
       updatebutt();
     });
  }
  private void InterstitialRewardedAd_Hide()
  {
    WriteLog("InterstitialRewardedAd_Hide Click!");
    MyModule.AdvManager_Comp.HideAdv(AdvType.IntersitialAd_RewardedAd);
  }

  private void WriteLog(string msg)
  {
    text.text += msg + "\n";
  }

  private void updatebutt()
  {
    OpenAd_Show_butt.interactable = MyModule.AdvManager_Comp.IsReady(AdvType.AppOpenAd);
    BannerAd_Show_butt.interactable = MyModule.AdvManager_Comp.IsReady(AdvType.BannerAd);
    InterstitialAd_Show_butt.interactable = MyModule.AdvManager_Comp.IsReady(AdvType.IntersitialAd);
    RewardedAd_Show_butt.interactable = MyModule.AdvManager_Comp.IsReady(AdvType.Video_RewardedAd);
    InterstitialRewardedAd_Show_butt.interactable = MyModule.AdvManager_Comp.IsReady(AdvType.IntersitialAd_RewardedAd);
  }
}