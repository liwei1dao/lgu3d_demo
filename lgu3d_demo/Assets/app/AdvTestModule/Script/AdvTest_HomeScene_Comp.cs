using System.Collections;
using UnityEngine;
using lgu3d;
using DG.Tweening;

/// <summary>
/// home 场景
/// </summary>
public class AdvTest_HomeScene_Comp : Module_BaseSceneComp<AdvTestModule>
{
  private string sceneName;
  public override void Load(ModelBase model, params object[] agrs)
  {
    base.Load(model, agrs);
    LoadEnd();
  }
  public override string GetSceneName()
  {
    return sceneName;
  }

  public ISceneLoadCompBase SetSceneName(string sname)
  {
    sceneName = sname;
    return this;
  }

  public override IEnumerator LoadScene()
  {
    Process = 1;
    MyModule.HomeView_Comp.Show();
    yield return 1;
  }
  public override IEnumerator UnloadScene()
  {
    Process = 1;
    yield return 1;
  }

}