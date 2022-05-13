using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Eliminate_GameView_Comp : Model_BaseViewComp<EliminateModule>
{
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "EliminateView");
    UIGameobject.OnAddClick("Button", Play);
    Hide();
    LoadEnd();
  }

  private void Play()
  {
    MyModule.GameScene_Comp.StartGame();
    Hide();
  }
}
