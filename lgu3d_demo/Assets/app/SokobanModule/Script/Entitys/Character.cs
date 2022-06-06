using System;
using lgu3d;
using UnityEngine;
using System.ComponentModel;
using System.Collections;
using DG.Tweening;
/// <summary>
/// 角色控制器
/// </summary>
public class Character : ItemBase
{
  private Animator animator;
  public override void Load(ItemBase entity, ItemType itype, Vector2 pos)
  {
    base.Load(entity, itype, pos);
    animator = GetComponentInChildren<Animator>();
  }
  public void Move(Vector3 pos, bool ispush)
  {
    if (ispush)
    {
      animator.SetInteger("State", 2);
    }
    else
    {
      animator.SetInteger("State", 1);
    }

    transform.DOMove(pos, 1.0f).OnComplete(() =>
    {
      animator.SetInteger("State", 0);
    });
    Vector3 endValue = (pos - transform.position).normalized;
    transform.DORotate(Quaternion.LookRotation(endValue).eulerAngles, 0.3f);
  }
}