using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Target;
    public float Speed;

    private float _cameraPositionY = 0;
    private float _cameraPositionZ = -10;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(Target.transform.position.x, _cameraPositionY , _cameraPositionZ), Speed) ;
    }
}
