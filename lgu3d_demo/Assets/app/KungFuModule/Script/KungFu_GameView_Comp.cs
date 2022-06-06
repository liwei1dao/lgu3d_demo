using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class KungFu_GameView_Comp : Model_BaseViewComp<KungFuModule>
{
  private UGUIEventListener bg;
  private Button play_butt;
  private Button launch_butt;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "EliminateView");
  }
}