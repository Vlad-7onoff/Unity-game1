using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _speed;

    private float _cameraPositionY = 0;
    private float _cameraPositionZ = -10;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition(), _speed) ;
    }

    private Vector3 TargetPosition()
    {
        return new Vector3(_target.transform.position.x, _cameraPositionY, _cameraPositionZ);
    }
}
