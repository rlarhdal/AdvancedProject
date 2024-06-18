using System;
using System.Numerics;

[Serializable]
public class PlayerData
{
    public int gold;
    public int happiness;
    
    public PlayerData(PlayerData player)
    {
        gold = player.gold;
        happiness = player.happiness;
    }
}
