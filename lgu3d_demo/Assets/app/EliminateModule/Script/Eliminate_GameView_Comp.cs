using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Eliminate_GameView_Comp : Model_BaseViewComp<EliminateModule>
{
  private UGUIEventListener bg;
  private Button play_butt;
  private Button launch_butt;
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "EliminateView");
    bg = UIGameobject.OnSubmit<UGUIEventListener>("bg");
    play_butt = UIGameobject.OnSubmit<Button>("Play");
    launch_butt = UIGameobject.OnSubmit<Button>("Launch");
    UIGameobject.OnAddClick("Play", Play);
    UIGameobject.OnAddClick("Launch", Launch);
    bg.onDragStart += dragstart;
    bg.onDrag += drag;
    bg.onDragEnd += dragend;
    Hide();
    LoadEnd();
  }

  public override void Show()
  {
    play_butt.gameObject.SetActive(true);
    launch_butt.gameObject.SetActive(false);
    base.Show();
  }

  private void dragstart(PointerEventData go, GameObject targetObj, Vector2 delta, params object[] eventArgs)
  {

  }

  private void drag(PointerEventData go, GameObject targetObj, Vector2 delta, params object[] eventArgs)
  {
    Vector2 pos = new Vector2(go.position.x - Screen.width / 2.0f, go.position.y);
    float angle = 90 - Vector2.Angle(pos.normalized, Vector2.right);
    MyModule.GameScene_Comp.KnobLauncher(angle);
    Debug.Log("drag:" + pos.ToString() + "angle:" + angle);
  }
  private void dragend(BaseEventData go, GameObject targetObj, params object[] eventArgs)
  {

  }
  private void Play()
  {
    MyModule.GameScene_Comp.StartGame();
    play_butt.gameObject.SetActive(false);
    launch_butt.gameObject.SetActive(true);
  }
  private void Launch()
  {
    MyModule.GameScene_Comp.LaunchCandy();
    MyModule.GameScene_Comp.FillingCandy();
  }
}
