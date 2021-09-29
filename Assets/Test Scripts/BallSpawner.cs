using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance { get; private set; }
    
    private void Start()
    {
        if (Instance != null)
            Destroy(gameObject);

        if (Instance == null)
            Instance = this;
        
        DontDestroyOnLoad(gameObject);
        
    }
}