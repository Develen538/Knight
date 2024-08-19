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

        foreach (var Player in allGameInfo)
        {
            if(Player.Healh >= _healh.maxValue)
            {
                Player.Healh += 0;
            }
            else
            {
                float Size = _healh.maxValue - _healh.value;
                Player.Healh += Size;

                if (Player.Healh >= _healh.maxValue)
                {
                    Player.Healh += 0;
                }
            }
        }
    }
}
