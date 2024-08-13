using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManegerGame : MonoBehaviour
{
    [SerializeField] private Slider _healh;
    [SerializeField] private Slider _armor;
    [SerializeField] private Slider _enamyHealh;
    [SerializeField] private Animator _animatorPlayer;
    [SerializeField] private Animator _animatorArcher;
    [SerializeField] private Animator _animatorEnamyWarrior;
    [SerializeField] private Animator _animatorEnamyWizard;


    private void Start()
    {
        Bars();
        PlayerAttack();
        EnemyAttack();
    }

    private void PlayerAttack()
    {
        int Size = 1;

        Attacks(_armor, _healh, _enamyHealh, "PlayerAttack", 5f, 1);

         if (Size == 1)
         {
           _animatorPlayer.SetFloat("Attack", 1);
            _animatorArcher.SetFloat("Attack", 1);
            _animatorEnamyWizard.SetFloat("Attack", 0);
            _animatorEnamyWarrior.SetFloat("Attack", 0);
        }
    }
    private void EnemyAttack()
    {
        int Size = 1;

        Attacks(_armor, _healh, _enamyHealh, "EnemyAttack", 7f, 2);

        if (Size == 1)
        {
            _animatorEnamyWarrior.SetFloat("Attack", 1);
            _animatorEnamyWizard.SetFloat("Attack", 1);
            _animatorPlayer.SetFloat("Attack", 0);
            _animatorArcher.SetFloat("Attack", 0);
        }
    }

    private void Bars()
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");

        foreach (var GameInfo in allGameInfo)
        {
            _armor.maxValue = GameInfo.Armor;
            _healh.maxValue = GameInfo.Healh;
            _enamyHealh.maxValue = GameInfo.EnemyHealh;
        }
    }

    private void Attacks(Slider armor, Slider healh, Slider Enemyhealh, string invoke, float time, int number)
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");

        foreach (var GameInfo in allGameInfo)
        {
            armor.value = GameInfo.Armor;
            healh.value = GameInfo.Healh;
            Enemyhealh.value = GameInfo.EnemyHealh;

          

            if (number == 1)
            {
                GameInfo.EnemyHealh -= GameInfo.Attack / GameInfo.EnemyArmor;
               
            }
            else if (number == 2)
            {
                GameInfo.Healh -= GameInfo.EnemyAttack / GameInfo.Armor;
            }
        }
        Invoke(invoke, time);
    }
}
