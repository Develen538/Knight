using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healh : MonoBehaviour
{
    [SerializeField] private Slider _healh;

   public void Restoring()
    {
        var allGameInfo = Resources.LoadAll<GameInfo>("");

        foreach (var Game in allGameInfo)
        {
            Game.Healh += 100;

            if(Game.Healh == _healh.maxValue)
            {
                Game.Healh += 0;
            }
        }
    }
}
