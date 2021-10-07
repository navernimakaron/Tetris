using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallMovement : MonoBehaviour, IMove
{
    
    [SerializeField] float _ballSpeed = 2f;
    Rigidbody2D _rigidbody2D;
    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
   
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        _rigidbody2D.velocity = Vector2.up * _ballSpeed;
    }



   
}