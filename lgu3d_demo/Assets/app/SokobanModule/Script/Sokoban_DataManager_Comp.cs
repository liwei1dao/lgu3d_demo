using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Sokoban_DataManager_Comp : ModelCompBase<SokobanModule>
{
  public int LastMap;                         //最后的mapId
  public bool IsNoAdv;                        //是否购买了去广告
  public override void Load(ModelBase model, params object[] agrs)
  {
    base.Load(model, agrs);
    LoadEnd();
  }

  public int GetLevelData()
  {
    if (LastMap <= SokobanLevels.Levels.Count)
    {
      return LastMap + 1;
    }
    else
    {
      int i = UnityEngine.Random.Range(50, SokobanLevels.Levels.Count);
      return i;
    }
  }

}