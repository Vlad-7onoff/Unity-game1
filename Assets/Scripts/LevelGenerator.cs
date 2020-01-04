using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _levelPartStart;
    [SerializeField] private List<Transform> _levelParts;
    [SerializeField] private PlayerController _player;
    [SerializeField] private float _playerDistanceSpawnLevelPart;
    private Vector3 _lastEndPosition;

    void Awake()
    {
        _lastEndPosition = _levelPartStart.GetComponent<Place>().GetEndPosition();

        int startingPartsCount = 2;

        for (int i = 0; i < startingPartsCount; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector2.Distance(new Vector2 (_player.transform.position.x,_player.transform.position.y), _lastEndPosition) < _playerDistanceSpawnLevelPart)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = _levelParts[Random.Range(0, _levelParts.Count)] ;
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, _lastEndPosition);
        _lastEndPosition = lastLevelPartTransform.GetComponent<Place>().GetEndPosition();
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
