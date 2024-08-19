using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _warrior;
    [SerializeField] private GameObject _wizard;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        int rand = Random.Range(1, 3);

        if (rand == 1)
        {
            _warrior.SetActive(true);
            _wizard.SetActive(false);
        }
        else if (rand == 2)
        {
            _warrior.SetActive(false);
            _wizard.SetActive(true);
        }
    }
}
