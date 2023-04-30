using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    private float _speed = 6.0f;
    private float _jumpPower = 20.0f;
    private bool _onGround = true;
    private float _movevar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _onGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _onGround = false;
    }
    void Start()
    {
        
    }
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        _movevar = Input.GetAxisRaw("Horizontal");
        //_rigidbody.velocity = new Vector2(_movevar * _speed, _rigidbody.velocity.y);

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            _rigidbody.velocity = new Vector2(-_speed, _rigidbody.velocity.y);
        }

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
        
    }
}
