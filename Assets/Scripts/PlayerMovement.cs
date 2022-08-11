using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _minSpeed = 1;
    [SerializeField] private int _maxSpeed = 10;
    
    private float _speed;
    
    private Vector3 _target;
    private bool _isTargetSet;

    private float Speed
    {
        get => _speed;
        set
        {
            if (value > _maxSpeed)
                _speed = _maxSpeed;
            else if (value < _minSpeed)
                _speed = _minSpeed;
            else
                _speed = value;
        }
    }

    private void Awake()
    {
        Speed = _maxSpeed;
    }

    private void Update()
    {
        if (!_isTargetSet) return;
        
        MovePlayer();
        //CalculateDirection(_target);

        if (transform.position == _target)
            _isTargetSet = false;
    }
    public void SetTarget(Vector2 target)
    {
        _target = target;
        _isTargetSet = true;
    }
    private void MovePlayer()
    {
        float step = Speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _target, step);
    }
    
    public void ChangeSpeed(float value)
    {
        Speed += value;
    }

    /*
    //MOVEMENTS USING PHYSIC:
     
    private Vector2 _direction;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    public void CalculateDirection(Vector3 target)
    {
        _direction = (target - transform.position);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition((Vector2)transform.position + _direction * Time.fixedDeltaTime);
    }
    */
}