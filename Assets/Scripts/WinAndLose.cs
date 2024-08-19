using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinAndLose : MonoBehaviour
{
    [SerializeField] private Slider _healh;
    [SerializeField] private Slider _enamyHealh;

    private void Update()
    {
        WinAndLosee();
    }

    private void WinAndLosee()
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");
        var allEnamyInfo = Resources.LoadAll<EnamyInfo>("");

        foreach (var PlayerInfo in allGameInfo)
        {
            foreach (var EnamyInfo in allEnamyInfo)
            {
                if (EnamyInfo.EnemyHealh <= 0 || PlayerInfo.Healh <= 0)
                {
                    PlayerInfo.Healh = 100;
                    EnamyInfo.EnemyHealh = 100;
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}
