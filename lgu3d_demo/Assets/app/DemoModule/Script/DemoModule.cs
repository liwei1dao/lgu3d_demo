using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

public class DemoModule : ManagerContorBase<DemoModule>
{
  public Demo_HomeView_Comp HomeView_Comp;
  public Demo_AdmobView_Comp AdmobView_Comp;
  public Demo_VungleView_Comp VungleView_Comp;
  public Demo_UnityView_Comp UnityView_Comp;
  public Demo_HomeScene_Comp HomeScene_Comp;
  public Demo_SceneChanageView_Comp SceneChanageView_Comp;
  public override void Load(params object[] agrs)
  {
    ResourceComp = AddComp<Module_ResourceComp>();
    TimerComp = AddComp<Module_TimerComp>();
    CoroutineComp = AddComp<Module_CoroutineComp>();
    SoundComp = AddComp<Module_SoundComp>();
    HomeScene_Comp = AddComp<Demo_HomeScene_Comp>();
    HomeView_Comp = AddComp<Demo_HomeView_Comp>();
    AdmobView_Comp = AddComp<Demo_AdmobView_Comp>();
    VungleView_Comp = AddComp<Demo_VungleView_Comp>();
    UnityView_Comp = AddComp<Demo_UnityView_Comp>();
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
