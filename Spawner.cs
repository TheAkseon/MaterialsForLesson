using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;

    private void Update()
    {
        Instantiate(_template, _spawnPoint.position, Quaternion.identity);
    }
}
