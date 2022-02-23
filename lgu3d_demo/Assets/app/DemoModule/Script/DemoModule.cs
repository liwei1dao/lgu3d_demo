using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

public class DemoModule : ManagerContorBase<DemoModule>
{
  public IAdv adv;
  private Demo_HomeView_Comp HomeView_Comp;
  private Demo_HomeScene_Comp HomeScene_Comp;
  private Demo_SceneChanageView_Comp SceneChanageView_Comp;
  public override void Load(params object[] agrs)
  {
    adv = VungleAdvModule.Instance;
    ResourceComp = AddComp<Module_ResourceComp>();
    TimerComp = AddComp<Module_TimerComp>();
    CoroutineComp = AddComp<Module_CoroutineComp>();
    SoundComp = AddComp<Module_SoundComp>();
    HomeScene_Comp = AddComp<Demo_HomeScene_Comp>();
    HomeView_Comp = AddComp<Demo_HomeView_Comp>();
    SceneChanageView_Comp = AddComp<Demo_SceneChanageView_Comp>();
    base.Load(agrs);
  }

  public override void Start(params object[] agrs)
  {
    base.Start(agrs);
#if !UNITY_EDITOR
    LoadBundle("Scenes");
#endif
    SceneModule.Instance.SetSceneCheduler(SceneChanageView_Comp);
    GoHome(SceneName.home);
  }
  public void GoHome(SceneName sceneName)
  {
    SceneModule.Instance.ChangeScene(HomeScene_Comp.SetSceneName(sceneName.ToString()));
  }
}
