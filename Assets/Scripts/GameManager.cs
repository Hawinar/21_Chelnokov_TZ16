using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int Money = 0;
    public static List<bool> AvailableLevels = new List<bool>() { true, false, false, false };
    public static Sprite Skin;
    public static List<bool> Skins = new List<bool>() { true, false, false, false, false, false, false, false};
}
