using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Eliminate_GameScene_Comp : Module_BaseSceneComp<EliminateModule>
{
  public override void Load(ModelBase module, params object[] agrs)
  {
  }

  public override IEnumerator LoadScene()
  {
    Process = 1;
    MyModule.GameView_Comp.Show();
    yield return 1;
  }

  public override IEnumerator UnloadScene()
  {
    yield return 1;
  }
}
