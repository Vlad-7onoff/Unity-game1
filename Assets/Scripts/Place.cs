using UnityEngine;

public class Place : Deactivatable
{
    [SerializeField] private Transform _endPosition;

    public Vector3 GetEndPosition()
    {
        return _endPosition.position;
    }
}
