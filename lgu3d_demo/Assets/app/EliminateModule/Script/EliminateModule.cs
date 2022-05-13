using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

/// <summary>
/// 消除游戏测试模块
/// </summary>
public class EliminateModule : ManagerContorBase<EliminateModule>
{
  public Eliminate_GameView_Comp GameView_Comp;
  public Eliminate_GameScene_Comp GameScene_Comp;
  public Eliminate_SceneChanageView_Comp SceneChanageView_Comp;
  public override void Load(params object[] agrs)
  {
    ResourceComp = AddComp<Module_ResourceComp>();
    TimerComp = AddComp<Module_TimerComp>();
    CoroutineComp = AddComp<Module_CoroutineComp>();
    SoundComp = AddComp<Module_SoundComp>();
    GameView_Comp = AddComp<Eliminate_GameView_Comp>();
    GameScene_Comp = AddComp<Eliminate_GameScene_Comp>();
    SceneChanageView_Comp = AddComp<Eliminate_SceneChanageView_Comp>();
    base.Load(agrs);
  }

  public override void Start(params object[] agrs)
  {
    base.Start(agrs);
#if !UNITY_EDITOR
    LoadBundle("Scenes");
#endif
    SceneModule.Instance.SetSceneCheduler(SceneChanageView_Comp);
    GoGame();
  }

  public void GoGame()
  {
    SceneModule.Instance.ChangeScene(GameScene_Comp.SetSceneName("game"));
  }
}
