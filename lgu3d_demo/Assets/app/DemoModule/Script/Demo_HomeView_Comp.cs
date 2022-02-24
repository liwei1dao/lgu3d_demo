using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Demo_HomeView_Comp : Model_BaseViewComp<DemoModule>
{

  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "HomeView");
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/admob", AdmobClick);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/vungle", VungleClick);
    UIGameobject.OnAddClick("Scroll View/Viewport/Content/unity", UnityClick);
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
}