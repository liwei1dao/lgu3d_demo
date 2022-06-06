using System.Collections;
using lgu3d;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Sokoban_GameView_Comp : Model_BaseViewComp<SokobanModule>
{
  private UGUIEventListener bg;
  private Button play_butt;
  private Button withdraw_butt;
  
  public override void Load(ModelBase module, params object[] agrs)
  {
    base.Load(module, "GameView");
    UIGameobject.OnAddClick("Joystick/left", leftClick);
    UIGameobject.OnAddClick("Joystick/right", rightClick);
    UIGameobject.OnAddClick("Joystick/up", upClick);
    UIGameobject.OnAddClick("Joystick/down", downClick);
    LoadEnd();
  }

  private void withdrawClick(){
      MyModule.GameScene_Comp.Move(MoveType.Left);
  }

  private void leftClick()
  {
    MyModule.GameScene_Comp.Move(MoveType.Left);
  }
  private void rightClick()
  {
    MyModule.GameScene_Comp.Move(MoveType.Right);
  }
  private void upClick()
  {
    MyModule.GameScene_Comp.Move(MoveType.Up);
  }
  private void downClick()
  {
    MyModule.GameScene_Comp.Move(MoveType.Down);
  }
}