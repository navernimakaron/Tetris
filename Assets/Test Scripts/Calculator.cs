using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private int _x;
    [SerializeField] private int _y;


    void Awake()
    {
        print(_x & _y);
        print(_x | _y);
        print(_x ^ _y);
        print(~_x);
        print(~_y);
        print(_x >> _y);
        print(_x << _y);
    }
}