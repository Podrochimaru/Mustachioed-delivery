using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speed = 6.0f;
    private float _jumpPower = 18.0f;
    private bool _onGround = true;
    private float _movevar;
    private bool isRight = true;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _anim;
    [SerializeField] private AudioSource _jumpsound;
    [SerializeField] private AudioSource _fallsound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _onGround = true;
        _fallsound.Play();
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
        Turn();
        AirCheck();
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
            _anim.Play("Jump");
            _jumpsound.Play();
        }
       
        
    }
    void Turn()
    {
        if (isRight && _movevar < 0f || !isRight && _movevar > 0f)
        {
            isRight = !isRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    void AirCheck()
    {
        if (_rigidbody.transform.position.y < -30f)
        {
            _rigidbody.transform.position = new Vector2(-7.76999998f, -0.579999924f);
        }
    }
}
