using System;
using System.Threading.Tasks;
using Google;
using lgu3d;
using UnityEngine;
using UnityEngine.UI;

public class ResLoadViewComp : Model_BaseViewComp<ResourceModule>, ILoadViewComp
{
  private Slider slider;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "LoadingView", UILevel.HightUI, UIOption.Find);
    slider = UIGameobject.OnSubmit<Slider>("Progress");
    LoadEnd();
  }
  public override void Hide()
  {
    ;
    base.Hide();
  }

  public void UpdateProgress(float progress, string describe)
  {
    slider.value = progress;
  }
}