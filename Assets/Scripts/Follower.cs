using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetTargetPosition(), _speed * Time.deltaTime);
    }

    private Vector3 GetTargetPosition()
    {
        return new Vector3(_target.transform.position.x, transform.position.y, transform.position.z);
    }
}
