using System;
using lgu3d;
using UnityEngine;
using System.ComponentModel;

/// <summary>
/// 糖果实体
/// </summary>
public class Candy : MonoEntityBase<Candy>
{
  public string CType;
  public int hitCount = 1;
  public CapsuleCollider bubCollider;

  public void Load(Candy entity, string cType)
  {
    CType = cType;
    bubCollider = gameObject.GetComponent<CapsuleCollider>();
    base.Load(entity);
  }

  public void Hide()
  {
    gameObject.SetActive(false);
  }

  public virtual void ReduceHitCount()
  {
    hitCount -= 1;
  }
}