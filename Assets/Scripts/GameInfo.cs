using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameInfo", menuName = "New GameInfo")]
public class GameInfo : ScriptableObject
{
    [SerializeField] public float Healh;
    [SerializeField] public float Armor;
    [SerializeField] public float Attack;
    [SerializeField] public float EnemyHealh;
    [SerializeField] public float EnemyArmor;
    [SerializeField] public float EnemyAttack;
}
