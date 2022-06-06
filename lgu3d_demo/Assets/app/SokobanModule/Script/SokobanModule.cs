using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

/// <summary>
/// 推箱子
/// 在有限的空间中 推动箱子到目标位置
/// </summary>
public class SokobanModule : ManagerContorBase<SokobanModule>
{
  public Sokoban_GameView_Comp GameView_Comp;
  public Sokoban_GameScene_Comp GameScene_Comp;
  public Sokoban_SceneChanageView_Comp SceneChanageView_Comp;
  public Sokoban_DataManager_Comp DataManager_Comp;
  public override void Load(params object[] agrs)
  {
    ResourceComp = AddComp<Module_ResourceComp>();
    TimerComp = AddComp<Module_TimerComp>();
    CoroutineComp = AddComp<Module_CoroutineComp>();
    SoundComp = AddComp<Module_SoundComp>();
    GameView_Comp = AddComp<Sokoban_GameView_Comp>();
    GameScene_Comp = AddComp<Sokoban_GameScene_Comp>();
    SceneChanageView_Comp = AddComp<Sokoban_SceneChanageView_Comp>();
    DataManager_Comp = AddComp<Sokoban_DataManager_Comp>();
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
