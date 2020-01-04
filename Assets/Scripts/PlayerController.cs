using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    public TMP_Text CoinDisplay;
    public float MoveSpeed;
    public float JumpForce;
    public LayerMask WhatIsGround;

    private int _coinCollected;
    private Rigidbody2D _rigidbody2D;
    private Collider2D _collider2D;
    public bool _grounded;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _collider2D = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        _grounded = Physics2D.IsTouchingLayers(_collider2D, WhatIsGround);

        _rigidbody2D.velocity = new Vector2(MoveSpeed, _rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_grounded)
            {
                _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, JumpForce);
            }
        }
    }

    public void PickUpCoin()
    {
        _coinCollected += 1;
        CoinDisplay.text ="Coins: " + _coinCollected.ToString();
    }
}
