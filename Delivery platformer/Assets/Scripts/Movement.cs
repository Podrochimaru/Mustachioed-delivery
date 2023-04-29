using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    private float _speed = 3.0f;
    private bool _onGround = true;
    private float _horizontal;

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


        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = new Vector2(_speed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            _rigidbody.velocity = new Vector2(-_speed, 0);
        }

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }
}
