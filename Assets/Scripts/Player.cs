using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinDisplay;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _whatIsGround;

    private int _coinCollected;
    private Rigidbody2D _rigidbody2D;
    private Collider2D _collider2D;
    private bool _grounded;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _collider2D = GetComponent<Collider2D>();
    }

    private void Update()
    {
        _grounded = Physics2D.IsTouchingLayers(_collider2D, _whatIsGround);

        _rigidbody2D.velocity = new Vector2(_moveSpeed, _rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_grounded)
            {
                _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce);
            }
        }
    }

    public void PickUpCoin()
    {
        _coinCollected += 1;
        _coinDisplay.text ="Coins: " + _coinCollected.ToString();
    }
}
