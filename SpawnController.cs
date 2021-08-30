using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private PartLevel[] _partLevels;
    private PartLevel _newPart;
    [SerializeField] private PartLevel _firstPart;

    private List<PartLevel> spawnedParts = new List<PartLevel>();

    private void Start()
    {
        spawnedParts.Add(_firstPart);
    }

    private void Update()
    {
        if (_camera.position.z > spawnedParts[spawnedParts.Count - 1]._end.position.z - 150)
        {
            SpawnPart();
        }
    }

    private void SpawnPart()
    {
        _newPart = Instantiate(_partLevels[Random.Range(0, _partLevels.Length)]);
        _newPart.transform.position = spawnedParts[spawnedParts.Count - 1]._end.position - _newPart._begin.position;
        spawnedParts.Add(_newPart);

        if (spawnedParts.Count >= 3)
        {
            Destroy(spawnedParts[0].gameObject);
            spawnedParts.RemoveAt(0);
        }
    }
}
