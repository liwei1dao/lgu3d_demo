using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;

/// <summary>
/// 偷袭功夫大师
/// 回合制
/// 背后偷袭功夫大师 功夫大师会快熟转身击败敌人
/// </summary>
public class KungFuModule : ManagerContorBase<KungFuModule>
{
  public KungFu_GameView_Comp GameView_Comp;
  public KungFu_GameScene_Comp GameScene_Comp;
  public KungFu_SceneChanageView_Comp SceneChanageView_Comp;
  public override void Load(params object[] agrs)
  {
  }

}
