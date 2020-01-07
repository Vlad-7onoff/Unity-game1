using UnityEngine;

public class Place : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public Vector3 GetEndPosition()
    {
        return _endPosition.position;
    }
}
