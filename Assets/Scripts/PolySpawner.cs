using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _polygonTargets = new GameObject[5];
    private Vector3 _position = new Vector3(3f, 8f, 0f);

    // Start is called before the first frame update
    void Awake()
    {
        foreach (var polygon in _polygonTargets)
        {
            polygon.transform.position = _position;
            Instantiate(polygon);
            _position += new Vector3(0f, -1f, 0f);

            foreach (var _polygon in _polygonTargets)
            {
                _polygon.transform.position = _position;
                _position += new Vector3(1f, 0f, 0f);
                Instantiate(_polygon);
            }
        }
    }
}