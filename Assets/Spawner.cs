using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _spawnGap = 3f;

    private delegate void upForce();

    private upForce force;

    private IEnumerator _coroutine()
    {
        yield return new WaitForSeconds(_spawnGap);
        Instantiate(_gameObject);
        force();
    }

    private void Start()
    {
        var rigidBody = _gameObject.GetComponent<Rigidbody>();
        force = Side;
    }

    private void Update()
    {
        StartCoroutine("_coroutine");
        StopCoroutine("_coroutine");
    }

    private void Side()
    {
        var rigidBody = _gameObject.GetComponent<Rigidbody>();
        rigidBody.AddForce(Vector3.left);
        Debug.Log("Side!");
        force = Up;
    }

    private void Up()
    {
        var rigidBody = _gameObject.GetComponent<Rigidbody>();
        rigidBody.AddForce(Vector3.up);
        Debug.Log("Up!");
        force = Side;
    }
}