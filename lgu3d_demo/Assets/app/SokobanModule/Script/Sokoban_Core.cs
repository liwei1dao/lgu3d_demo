using System.Collections.Generic;
public enum MoveType
{
  Up,
  Down,
  Left,
  Right,
}

public enum ItemType
{
  Wall = 0,
  Ground = 1, //0x1
  Target = 1 << 1, //0x2
  Box = 1 << 2, //0x4
  Character = 1 << 3, //0x8
}
public static class SokobanConstant
{
  public static float Item_Unit = 1.15f;

}

/// <summary>
/// 1 地图
/// </summary>
public static class SokobanLevels
{
  public static List<int[,]> Levels = new List<int[,]>() {
    new int[,]
    {
      {0,0,0,0,0,0},
      {0,8|1,1,4|1,2,0},
      {0,0,0,0,0,0},
    },
};
}