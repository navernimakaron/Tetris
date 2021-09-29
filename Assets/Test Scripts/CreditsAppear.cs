using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CreditsAppear : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _credits;

    private void Awake()
    {
        _credits.enabled = false;
    }

    private void OnMouseOver()
    {
        _credits.enabled = true;
    }
}