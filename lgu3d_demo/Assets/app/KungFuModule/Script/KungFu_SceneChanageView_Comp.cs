using lgu3d;


public class KungFu_SceneChanageView_Comp : Model_BaseViewComp<KungFuModule>, IScenesChedulerBase
{

  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "LoadingView", UILevel.HightUI, UIOption.Find);
    Hide();
    LoadEnd();
  }


  public void EndLoadChanage()
  {

  }

  public void StartLoadChanage()
  {

  }

  public void UpdataProgress(float Progress)
  {

  }
}
