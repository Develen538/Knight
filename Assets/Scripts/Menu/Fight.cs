using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight : MonoBehaviour
{
    [SerializeField] private GameObject _healh;
    [SerializeField] private Sprite[] _icon;
    [SerializeField] private Image _image;

    private int number = 0;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void FightIcon()
    {
        if (number == 0)
        {
            Time.timeScale = 1;
            _image.sprite = _icon[1];
            number = 1;

            _healh.SetActive(false);
        }
        else if (number == 1)
        {
            Time.timeScale = 0;
            _image.sprite = _icon[0];
            number = 0;

            _healh.SetActive(true);
        }
    }

    
}
