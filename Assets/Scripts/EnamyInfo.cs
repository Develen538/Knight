using UnityEngine;

[CreateAssetMenu(fileName = "GameInfo", menuName = "New EnamyInfo")]
public class EnamyInfo : ScriptableObject
{
    [SerializeField] public float EnemyHealh;
    [SerializeField] public float EnemyArmor;
    [SerializeField] public float EnemyAttack;
}
