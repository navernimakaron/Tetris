using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallMovement : MonoBehaviour, IScore
{
    int _scoreCounter = 0;
    [SerializeField] float ballSpeed = 2f;
    Rigidbody2D _rigidbody2D;
    IScore _score;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _score.score = 0;
    }


    public int Score()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _scoreCounter++;
        }

        _score.score += _scoreCounter;
        return _score.score;
    }
}