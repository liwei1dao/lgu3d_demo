using System;
using lgu3d;
using UnityEngine;
using System.ComponentModel;
using System.Collections;
using DG.Tweening;

/// <summary>
/// 角色控制器
/// </summary>
public class Box : ItemBase
{

  public void Move(Vector3 pos)
  {
    transform.DOMove(pos, 1.0f);
    Debug.Log("Box move " + pos.ToString());
  }
}