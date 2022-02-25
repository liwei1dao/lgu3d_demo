using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

public class AdvTestModule : ManagerContorBase<AdvTestModule>
{
  public AdvTest_AdvManager_Comp AdvManager_Comp;
  public AdvTest_HomeView_Comp HomeView_Comp;
  public AdvTest_AdmobView_Comp AdmobView_Comp;
  public AdvTest_VungleView_Comp VungleView_Comp;
  public AdvTest_UnityView_Comp UnityView_Comp;
  public AdvTest_HomeScene_Comp HomeScene_Comp;
  public AdvTest_SceneChanageView_Comp SceneChanageView_Comp;
  public override void Load(params object[] agrs)
  {
    ResourceComp = AddComp<Module_ResourceComp>();
    TimerComp = AddComp<Module_TimerComp>();
    CoroutineComp = AddComp<Module_CoroutineComp>();
    SoundComp = AddComp<Module_SoundComp>();
    AdvManager_Comp = AddComp<AdvTest_AdvManager_Comp>();
    HomeScene_Comp = AddComp<AdvTest_HomeScene_Comp>();
    HomeView_Comp = AddComp<AdvTest_HomeView_Comp>();
    AdmobView_Comp = AddComp<AdvTest_AdmobView_Comp>();
    VungleView_Comp = AddComp<AdvTest_VungleView_Comp>();
    UnityView_Comp = AddComp<AdvTest_UnityView_Comp>();
    SceneChanageView_Comp = AddComp<AdvTest_SceneChanageView_Comp>();
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
