using System;
using lgu3d;
using UnityEngine;
using System.ComponentModel;
using System.Collections;

/// <summary>
/// 角色控制器
/// </summary>
public class ItemBase : MonoEntityBase<ItemBase>
{
  public Vector2 pos;
  public ItemType itype;

  public virtual void Load(ItemBase entity, ItemType itype, Vector2 pos)
  {
    this.itype = itype;
    this.pos = pos;
    base.Load(entity);
  }

}