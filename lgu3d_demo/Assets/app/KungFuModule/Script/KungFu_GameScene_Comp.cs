using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class KungFu_GameScene_Comp : Module_BaseSceneComp<KungFuModule>
{
  const string objpool = "candy";
  private GameObject candyTrans;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module);
    MyModule.RegisterDictionaryPool<Candy>(objpool, createCandy);
    LoadEnd();
  }

  public override IEnumerator LoadScene()
  {
    Process = 1;
    yield return 1;
  }

  public override IEnumerator UnloadScene()
  {
    yield return 1;
  }


  private Candy createCandy(string candyType)
  {
    GameObject obj = MyModule.LoadAsset<GameObject>("Prefab", candyType);
    GameObject _obj = obj.CreateToParnt(candyTrans);
    Candy candy = _obj.AddMissingComponent<Candy>();
    candy.Load(candy, candyType);
    return candy;
  }
}