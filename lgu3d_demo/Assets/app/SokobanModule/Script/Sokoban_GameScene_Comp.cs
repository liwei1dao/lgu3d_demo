using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Sokoban_GameScene_Comp : Module_BaseSceneComp<SokobanModule>
{
  private GameObject levelTran;
  private GameObject candyTrans;
  private Character character;
  private List<Box> boxs;
  private int[,] levelMap;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module);
    LoadEnd();
  }

  public override IEnumerator LoadScene()
  {
    levelTran = GameObject.Find("level");
    initlevel(SokobanLevels.Levels[0]);
    Process = 1;
    yield return 1;
  }

  public override IEnumerator UnloadScene()
  {
    yield return 1;
  }

  private void Withdraw(){

  }

  private void initlevel(int[,] level)
  {
    boxs = new List<Box>();
    levelMap = level;
    for (int i = 0; i < level.GetLength(0); i++)
    {
      for (int j = 0; j < level.GetLength(1); j++)
      {
        int it = level[i, j];
        float x = -1 * j * SokobanConstant.Item_Unit + (level.GetLength(1) * SokobanConstant.Item_Unit / 2.0f);
        float y = i * SokobanConstant.Item_Unit - ((level.GetLength(0) - 1) * SokobanConstant.Item_Unit / 2.0f);
        if ((it & 1) > 0)
        {
          GameObject item = MyModule.LoadAsset<GameObject>("Prefab", "Ground").CreateToParnt(levelTran, new Vector3(x, 0, y));
          Ground ground = item.AddMissingComponent<Ground>();
          ground.Load(ground, ItemType.Ground, new Vector2(i, j));
        }
        if ((it & 2) > 0)
        {
          GameObject item = MyModule.LoadAsset<GameObject>("Prefab", "Target").CreateToParnt(levelTran, new Vector3(x, 0, y));
          Target target = item.AddMissingComponent<Target>();
          target.Load(target, ItemType.Target, new Vector2(i, j));
        }
        if ((it & 4) > 0)
        {
          GameObject item = MyModule.LoadAsset<GameObject>("Prefab", "Box").CreateToParnt(levelTran, new Vector3(x, 0, y));
          Box box = item.AddMissingComponent<Box>();
          box.Load(box, ItemType.Box, new Vector2(i, j));
          boxs.Add(box);
        }
        if ((it & 8) > 0)
        {
          GameObject item = MyModule.LoadAsset<GameObject>("Prefab", "Character_01").CreateToParnt(levelTran, new Vector3(x, 0, y));
          character = item.AddMissingComponent<Character>();
          character.Load(character, ItemType.Character, new Vector2(i, j));
        }
      }
    }
  }

  public void Move(MoveType mtype)
  {
    if (isCheckMove(mtype))
    {
      bool ispush = false;
      Vector2 tpos = FindTargerPos(character.pos, mtype);
      int it = levelMap[(int)tpos.x, (int)tpos.y];
      if ((it & 4) > 0)
      {
        for (var i = 0; i < boxs.Count; i++)
        {
          if (boxs[i].pos == tpos)
          {
            Vector2 t2pos = FindTargerPos(tpos, mtype);
            levelMap[(int)tpos.x, (int)tpos.y] &= ~4;
            levelMap[(int)t2pos.x, (int)t2pos.y] |= 4;
            boxs[i].Move(ToVector3(t2pos));
            ispush = true;
            break;
          }
        }
      }
      character.Move(ToVector3(tpos), ispush);
      levelMap[(int)character.pos.x, (int)character.pos.y] = levelMap[(int)character.pos.x, (int)character.pos.y] & (~8);
      levelMap[(int)tpos.x, (int)tpos.y] |= 8;
      character.pos = tpos;
      Debug.Log("s:" + levelMap[(int)character.pos.x, (int)character.pos.y].ToString() + "|e:" + levelMap[(int)tpos.x, (int)tpos.y].ToString());
    }
    else
    {
      Debug.Log("isCheckMove:false");
    }
  }

  private bool isCheckMove(MoveType mtype)
  {
    Vector2 cpos = character.pos;
    Vector2 tpos = FindTargerPos(cpos, mtype);
    int it = levelMap[(int)tpos.x, (int)tpos.y];
    Debug.Log("cpos:" + cpos.ToString() + "|tpos:" + tpos.ToString() + "it:" + it.ToString());
    if (it == 0)
    {
      return false;
    }
    else if (it == 1 || it == 2)
    {
      return true;
    }
    else if ((it & 4) > 0)
    {
      Vector2 tpos2 = FindTargerPos(tpos, mtype);
      int it2 = levelMap[(int)tpos2.x, (int)tpos2.y];
      Debug.Log("tpos:" + tpos.ToString() + "|tpos2:" + tpos2.ToString() + "it2:" + it2.ToString());
      if (it2 == 1 || it2 == 2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    return false;
  }

  private Vector2 FindTargerPos(Vector2 pos, MoveType mtype)
  {
    Vector2 tcpos = pos;
    switch (mtype)
    {
      case MoveType.Left:
        tcpos = pos + new Vector2(-1, 0);
        break;
      case MoveType.Right:
        tcpos = pos + new Vector2(1, 0);
        break;
      case MoveType.Up:
        tcpos = pos + new Vector2(0, 1);
        break;
      case MoveType.Down:
        tcpos = pos + new Vector2(0, -1);
        break;
    }
    return tcpos;
  }

  private Vector3 ToVector3(Vector2 pos)
  {
    float x = -1 * pos.y * SokobanConstant.Item_Unit + (levelMap.GetLength(1) * SokobanConstant.Item_Unit / 2.0f);
    float y = pos.x * SokobanConstant.Item_Unit - ((levelMap.GetLength(0) - 1) * SokobanConstant.Item_Unit / 2.0f);
    return new Vector3(x, 0, y);
  }

  private bool IsWin()
  {
    for (int i = 0; i < levelMap.GetLength(0); i++)
    {
      for (int j = 0; j < levelMap.GetLength(1); j++)
      {
        if (levelMap[i, j] == 2){
          return false;
        }
      }
    }
    return true;
  }
}