using UnityEngine;

[CreateAssetMenu(fileName = "GameInfo", menuName = "New PlayerInfo")]
public class GameInfo : ScriptableObject
{
    [SerializeField] public float Healh;
    [SerializeField] public float Armor;
    [SerializeField] public float Attack;
}
