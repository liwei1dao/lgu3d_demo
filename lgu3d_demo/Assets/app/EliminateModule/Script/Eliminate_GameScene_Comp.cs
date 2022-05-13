using System.Collections;
using System.Collections.Generic;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Eliminate_GameScene_Comp : Module_BaseSceneComp<EliminateModule>
{
  private Transform[] puts;
  private GameObject candyTrans;
  public List<Candy> bubbleList = new List<Candy>();
  public bool isCanClick = true;
  const string objpool = "candy";
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module);
    MyModule.RegisterDictionaryPool<Candy>(objpool, createCandy);
    LoadEnd();
  }

  public override IEnumerator LoadScene()
  {
    Process = 1;
    candyTrans = GameObject.Find("Scene/candyTrans");
    GameObject _puts = GameObject.Find("Scene/puts");
    puts = new Transform[_puts.transform.childCount];
    for (var i = 0; i < _puts.transform.childCount; i++)
    {
      puts[i] = _puts.transform.GetChild(i);
    }
    MyModule.GameView_Comp.Show();
    yield return 1;
  }

  public override IEnumerator UnloadScene()
  {
    yield return 1;
  }

  public void StartGame()
  {
    MyModule.StartCoroutine(StartGameAnim());
  }
  private IEnumerator StartGameAnim()
  {
    bubbleList.Clear();
    List<Transform> tempos = puts.ToListCopy();
    for (var i = 0; i < 10; i++)
    {
      int index = Random.Range(0, tempos.Count);
      Vector3 pos = tempos[index].position;
      Candy candy = MyModule.GetByDictionaryPool<Candy>(objpool, RandomCandyType());
      candy.transform.position = pos;
      bubbleList.Add(candy);
      tempos.RemoveAt(index);
    }
    yield return new WaitForSeconds(1);
  }

  private string RandomCandyType()
  {
    string[] ctypes = new string[] { "item_001", "item_002", "item_003" };
    return ctypes[Random.Range(0, ctypes.Length)];
  }

  private Candy createCandy(string candyType)
  {
    GameObject obj = MyModule.LoadAsset<GameObject>("Prefab", candyType);
    GameObject _obj = obj.CreateToParnt(candyTrans);
    Candy candy = _obj.AddMissingComponent<Candy>();
    candy.Load(candy, candyType);
    return candy;
  }

  /// <summary>
  /// 消除
  /// </summary>
  /// <param name="candy"></param>
  public void Clean(Candy candy)
  {
    Vector3 candyPos = candy.transform.localPosition;
    List<Candy> linkList = GetLinkBubble(candy);
  }

  IEnumerator IECleanBubble(List<Candy> linkList)
  {
    isCanClick = false;
    int recycleCount = 0;
    if (linkList.Count > 2)
    {
      int i = 0;
      while (i < linkList.Count)
      {
        linkList[i].ReduceHitCount();
        if (linkList[i].hitCount <= 0)
        {
          recycleCount++;
        }

        RecycleBubble(linkList[i]);
        ++i;
        yield return new WaitForSeconds(0.1f);
      }
    }

    isCanClick = true;
  }

  /// <summary>
  /// 广度优先搜索 查找相连的 泡泡
  /// </summary>
  /// <returns>The link bubble.</returns>
  /// <param name="bubble">Bubble.</param>
  List<Candy> GetLinkBubble(Candy bubble)
  {
    List<Candy> resList = new List<Candy>();
    List<Candy> tempList = new List<Candy>();

    tempList.AddRange(bubbleList);

    //remove different bubble
    int index = 0;
    while (index < tempList.Count)
    {
      if (tempList[index].CType != bubble.CType)
      {
        tempList.RemoveAt(index);
      }
      else
      {
        index++;
      }
    }

    //get the link bubble of select one
    resList.Add(bubble);
    tempList.Remove(bubble);
    int i = 0;
    while (i < resList.Count)
    {
      Candy curBub = resList[i];
      int j = 0;
      while (j < tempList.Count)
      {
        if (IsTouch(curBub, tempList[j]))
        {
          resList.Add(tempList[j]);
          tempList.RemoveAt(j);
        }
        else
        {
          ++j;
        }
      }
      ++i;
    }
    return resList;
  }

  /// <summary>
  /// 判断两个泡泡是否相连
  /// </summary>
  /// <returns><c>true</c> if this instance is touch the specified a b; otherwise, <c>false</c>.</returns>
  /// <param name="a">The alpha component.</param>
  /// <param name="b">The blue component.</param>
  bool IsTouch(Candy a, Candy b)
  {
    float distance = Vector3.Distance(a.transform.localPosition, b.transform.localPosition);

    float radiusA = a.bubCollider.radius;
    float radiusB = b.bubCollider.radius;
    float offset = 5f;
    float calDistance = radiusA + radiusB + offset;
    if (calDistance >= distance)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  /// <summary>
  /// 回收一个泡泡
  /// </summary>
  /// <param name="bubble">Bubble.</param>
  public void RecycleBubble(Candy bubble)
  {
    Debug.Log("回收一个泡泡 " + bubble.CType);
    if (bubbleList.Contains(bubble) == false)
    {
      return;
    }
    if (bubble.hitCount > 0)
    {
      return;
    }
    bubbleList.Remove(bubble);
    bubble.Hide();
    MyModule.PushByDictionaryPool<Candy>(objpool, bubble.CType, bubble);
  }

}
