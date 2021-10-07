using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _polygonTargets = new GameObject[6];
    private Vector3 _position = new Vector3(-3.65f, 3.5f, 0f);

    void Awake()
    {
        for (int i = 0; i < _polygonTargets.Length; i++)
        {
            for (int j = 0; j < _polygonTargets.Length; j++)
            {
                var randomLine = UnityEngine.Random.Range(0, _polygonTargets.Length);
                _polygonTargets[randomLine].transform.position = _position;
                _position += new Vector3(1.25f, 0f, 0f);
                Instantiate(_polygonTargets[randomLine]);
            }

            var randomRow = UnityEngine.Random.Range(0, _polygonTargets.Length);
            _polygonTargets[randomRow].transform.position = _position;
            _position += new Vector3(-7.5f, -.5f, 0f);
            Instantiate(_polygonTargets[randomRow]);
        }
    }
}