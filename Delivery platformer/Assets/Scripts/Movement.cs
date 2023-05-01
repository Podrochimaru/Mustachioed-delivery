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
    private bool _isPaused = false;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _anim;
    [SerializeField] private AudioSource _jumpsound;
    [SerializeField] private AudioSource _fallsound;
    [SerializeField] private GameObject _pause;

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
        Animate();
        Pause();
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
    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _isPaused == false)
        {
            _pause.SetActive(true);
            Time.timeScale = 0;
            _isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _isPaused == true)
        {
            _pause.SetActive(false);
            Time.timeScale = 1;
            _isPaused = false;
        }
    }
    void Animate()
    {
        _anim.SetFloat("Speed", Mathf.Abs(_rigidbody.velocity.x));
        _anim.SetBool("Grounded", _onGround);
    }
}
