using lgu3d;

public class PangolinAdvDomeMainViewComp : Model_BaseViewComp<PangolinAdvDomeModule>
{
    public override void Load(ModelBase _ModelContorl, params object[] _Agr)
    {
        base.Load(_ModelContorl, "DemoMain");
        UIGameobject.OnAddClick("ShowSplashAd",ShowSplashAd);
        UIGameobject.OnAddClick("ShowInterstitialAd",ShowInterstitialAd);
        UIGameobject.OnAddClick("ShowFullScreenVideoAd",ShowFullScreenVideoAd);
        UIGameobject.OnAddClick("ShowBannerAd",ShowBannerAd);
        UIGameobject.OnAddClick("ShowRewardAd",ShowRewardAd);
        UIGameobject.OnAddClick("ShowFeedAd",ShowFeedAd);
        LoadEnd();
    }

    private void ShowSplashAd (){
        PangolinAdvModule.Instance.ShowSplashAd("801121648");
    }

    private void ShowInterstitialAd (){
        PangolinAdvModule.Instance.ShowInterstitialAd("901121133");
    }
    private void ShowFullScreenVideoAd (){
        PangolinAdvModule.Instance.ShowFullScreenVideoAd("901121073");
    }
    private void ShowBannerAd (){
        PangolinAdvModule.Instance.ShowBannerAd("901121246");
    }
    private void ShowRewardAd (){
        PangolinAdvModule.Instance.ShowRewardAd("901121593");
    }
    private void ShowFeedAd (){
        PangolinAdvModule.Instance.ShowFeedAd("901121253");
    }
}
