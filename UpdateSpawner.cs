using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Update()
    {
        Instantiate(_template, _spawnPoints[0].position, Quaternion.identity);
        Instantiate(_template, _spawnPoints[1].position, Quaternion.identity);
        Instantiate(_template, _spawnPoints[2].position, Quaternion.identity);
        Instantiate(_template, _spawnPoints[3].position, Quaternion.identity);
    }
}
