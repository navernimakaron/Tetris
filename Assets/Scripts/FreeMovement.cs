using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour, IMove
{
    private float _horizontal;
    private float _vertical;
    [SerializeField] private float _speed = 3f;

    private void Start()
    {
        
    }

    public void Move()
    {
        _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        
        gameObject.transform.Translate(_horizontal, 0f, 0f);
        gameObject.transform.Translate( 0f, _vertical, 0f);
    }

    private void Update()
    {
        Move();
    }
}
