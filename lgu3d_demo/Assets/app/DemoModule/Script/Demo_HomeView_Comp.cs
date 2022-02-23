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
  }
}