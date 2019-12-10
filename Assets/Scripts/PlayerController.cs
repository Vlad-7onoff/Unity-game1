using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TMP_Text CoinDisplay;
    public float MoveSpeed;
    public float JumpForce;
    public LayerMask WhatIsGround;

    private int _coinCollected;
    private Rigidbody2D _myRigidbody2D;
    private Collider2D _myCollider2D;
    public bool _grounded;

    void Start()
    {
        _myRigidbody2D = GetComponent<Rigidbody2D>();

        _myCollider2D = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        _grounded = Physics2D.IsTouchingLayers(_myCollider2D, WhatIsGround);

        _myRigidbody2D.velocity = new Vector2(MoveSpeed, _myRigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_grounded)
            {
                _myRigidbody2D.velocity = new Vector2(_myRigidbody2D.velocity.x, JumpForce);
            }
        }
    }

    public void PickUpCoin()
    {
        _coinCollected += 1;
        CoinDisplay.text ="Coins: " + _coinCollected.ToString();
    }
}
