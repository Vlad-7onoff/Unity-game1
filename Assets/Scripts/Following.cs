using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition(), _speed * Time.deltaTime);
    }

    private Vector3 TargetPosition()
    {
        return new Vector3(_target.transform.position.x, transform.position.y, transform.position.z);
    }
}
