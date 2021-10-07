using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

public class Destructable : MonoBehaviour, IScore
{
    public int Score { get; set; }

    private TMP_Text _text;

    private void Start()
    {
        _text = FindObjectOfType<TMP_Text>();
    }

    private void Update()
    {
        _text.text = $"{Score}";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other?.gameObject.CompareTag("Ball") == true)
        {
            Score += 100;
            Destroy(gameObject);
            Debug.Log(Score);
        }
    }
}