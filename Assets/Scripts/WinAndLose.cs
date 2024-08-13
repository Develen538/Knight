using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAndLose : MonoBehaviour
{
    private void Update()
    {
        WinAndLosee();
    }

    private void WinAndLosee()
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");

        foreach (var GameInfo in allGameInfo)
        {
            if (GameInfo.EnemyHealh <= 0 || GameInfo.Healh <= 0)
            {
                GameInfo.Healh = 100;
                GameInfo.EnemyHealh = 100;
                SceneManager.LoadScene(0);
            }
        }
    }
}
