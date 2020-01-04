using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    [SerializeField] private GameObject _endPosition;

    private void OnEnable()
    {
        Invoke("Deactivate", 30f);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public Vector3 GetEndPosition()
    {
        return _endPosition.transform.position;
    }
}
