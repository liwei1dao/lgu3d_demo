using System;
using lgu3d;
using UnityEngine;
using System.ComponentModel;
using System.Collections;

/// <summary>
/// 糖果实体
/// </summary>
public class Candy : MonoEntityBase<Candy>
{
  public string CType;
  public int hitCount = 1;
  public CapsuleCollider bubCollider;
  public Rigidbody rbody;
  public void Load(Candy entity, string cType)
  {
    CType = cType;
    bubCollider = gameObject.GetComponent<CapsuleCollider>();
    rbody = gameObject.GetComponent<Rigidbody>();
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

  public void AddForces(Vector3 force)
  {
    rbody.AddForce(force, ForceMode.Impulse);
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == EliminateTags.Candy)
    {
      EliminateModule.Instance.GameScene_Comp.Clean(this);
    }
  }

}