using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _polygonTargets = new GameObject[5];
    private Vector3 _position = new Vector3(-2f, 4f, 0f);


    void Awake()
    {
        Debug.Log(BallSpawner.Instance);
        for (int i = 0; i < _polygonTargets.Length; i++)
        {
            for (int j = 0; j < _polygonTargets.Length; j++)
            {
                var randomLine = UnityEngine.Random.Range(0, 5);
                _polygonTargets[randomLine].transform.position = _position;
                _position += new Vector3(1f, 0f, 0f);
                Instantiate(_polygonTargets[randomLine]);
            }

            var randomRow = UnityEngine.Random.Range(0, 5);
            _polygonTargets[randomRow].transform.position = _position;
            _position += new Vector3(-5f, -1f, 0f);
            Instantiate(_polygonTargets[randomRow]);
        }
    }
}