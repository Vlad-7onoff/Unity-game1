using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Place _place;
    [SerializeField] private List<Place> _levelParts;
    [SerializeField] private Player _player;
    [SerializeField] private float _spawnDistance;
    [SerializeField] private PlaceDetector _placeDetector;

    private Vector3 _lastEndPosition;

    private void Awake()
    {
        _lastEndPosition = _place.GetEndPosition();

        int startingPartsCount = 2;

        for (int i = 0; i < startingPartsCount; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector2.Distance(_player.transform.position, _lastEndPosition) < _spawnDistance)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = _levelParts[Random.Range(0, _levelParts.Count)].transform;
        Transform levelPartTransform = Instantiate(chosenLevelPart, _lastEndPosition, Quaternion.identity);
        Transform lastLevelPartTransform = levelPartTransform;
        _lastEndPosition = lastLevelPartTransform.GetComponent<Place>().GetEndPosition();
    }

    private void OnPlaceDetecting(Place place)
    {
        place.Deactivate();
    }

    private void OnEnable()
    {
        _placeDetector.PlaceDetecting += OnPlaceDetecting;
    }

    private void OnDisable()
    {
        _placeDetector.PlaceDetecting -= OnPlaceDetecting;
    }
}
