using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField] private GameObject _item;

    private void Start()
    {
        Instantiate(_item, transform);
    }
}