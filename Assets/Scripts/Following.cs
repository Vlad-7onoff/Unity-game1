using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _cameraPositionY;
    [SerializeField] private float _cameraPositionZ;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition(), _speed * Time.deltaTime) ;
    }

    private Vector3 TargetPosition()
    {
        return new Vector3(_target.transform.position.x, _cameraPositionY, _cameraPositionZ);
    }
}
