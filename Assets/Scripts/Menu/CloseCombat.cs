using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseCombat : MonoBehaviour
{
    [SerializeField] private GameObject _archer;
    [SerializeField] private GameObject _player;
    [SerializeField] private Sprite[] _icon;
    [SerializeField] private Image _image;

    private int number = 0;

    public void Attack()
    {
        if (number == 0)
        {
            Time.timeScale = 0;

            _image.sprite = _icon[0];
            number = 1;

            _player.SetActive(true);
            _archer.SetActive(false);

            Time.timeScale = 1;
        }
        else if (number == 1)
        {
            Time.timeScale = 0;

            _image.sprite = _icon[1];
            number = 0;

            _player.SetActive(false);
            _archer.SetActive(true);

            Time.timeScale = 1;
        }
    }
}
