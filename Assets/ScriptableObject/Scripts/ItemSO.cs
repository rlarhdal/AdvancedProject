using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName ="ItemDefault")]
public class ItemSO : ScriptableObject
{
    [Header("# Amount")]
    public int goldAmount;
    public int autoGoldAmount;

    [Header("# Percentage")]
    public float goldPercent;
    public float happinessPercent;
}
