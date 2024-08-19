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
    [SerializeField] private Fight _fight;

    private int numbers;

    public void Attack()
    {
        if (numbers == 0)
        {
            if (_fight.number == 1)
            {
                Time.timeScale = 0;

                _image.sprite = _icon[0];
                numbers = 1;

                _player.SetActive(true);
                _archer.SetActive(false);

                Time.timeScale = 1;
            }
        }
        else if (numbers == 1)
        {
            Time.timeScale = 0;

            _image.sprite = _icon[1];
            numbers = 0;

            _player.SetActive(false);
            _archer.SetActive(true);

            Time.timeScale = 1;
        }
    }
}
