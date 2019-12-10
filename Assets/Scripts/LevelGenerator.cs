using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _levelPartStart;
    [SerializeField] private List<Transform> _levelPartList;
    [SerializeField] private PlayerController _player;

    private const float _playerDistanceSpawnLevelPart = 30f;
    private Vector3 _lastEndPosition;

    void Awake()
    {
        _lastEndPosition = _levelPartStart.Find("EndPosition").position;

        int startingSpawnLevelParts = 2;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(new Vector3 (_player.transform.position.x,_player.transform.position.y), _lastEndPosition) < _playerDistanceSpawnLevelPart)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = _levelPartList[Random.Range(0, _levelPartList.Count)] ;
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, _lastEndPosition);
        _lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
