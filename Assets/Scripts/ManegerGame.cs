using UnityEngine;
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
        var allPlayerInfo = Resources.LoadAll<GameInfo>("");
        var allEnamyInfo = Resources.LoadAll<EnamyInfo>("");

        foreach (var PlayerInfo in allPlayerInfo)
        {
            _armor.maxValue = PlayerInfo.Armor;
            _healh.maxValue = PlayerInfo.Healh;
        }
        foreach (var EnamyInfo in allEnamyInfo)
        {
            _enamyHealh.maxValue = EnamyInfo.EnemyHealh;
        }
    }

    private void Attacks(Slider armor, Slider healh, Slider Enemyhealh, string invoke, float time, int number)
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");
        var allEnamyInfo = Resources.LoadAll<EnamyInfo>("");

        foreach (var PlayerInfo in allGameInfo)
        {
            armor.value = PlayerInfo.Armor;
            healh.value = PlayerInfo.Healh;

            foreach (var EnamyInfo in allEnamyInfo)
            {
                Enemyhealh.value = EnamyInfo.EnemyHealh;

                if (number == 1)
                {
                    EnamyInfo.EnemyHealh -= PlayerInfo.Attack / EnamyInfo.EnemyArmor;

                }
                else if (number == 2)
                {
                    PlayerInfo.Healh -= EnamyInfo.EnemyAttack / PlayerInfo.Armor;
                }
            }
        }
        Invoke(invoke, time);
    }
}
