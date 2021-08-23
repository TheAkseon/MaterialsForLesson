using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopedSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Update()
    {
        for(int i = 0; i < 4;i++)
        {
            Instantiate(_template, _spawnPoints[i].position, Quaternion.identity);
        }
    }
}
