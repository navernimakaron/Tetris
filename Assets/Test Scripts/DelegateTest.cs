using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    
    private void Start()
    {
        int a = 25;
        string _string = "Hello";
        bool _bool = true;
        char _char = 'X';
        
        RefMethod(ref a, 30);
        NoRefMethod(a, 30);
        OutMethod(_bool, _char, in _string);

    }

    int RefMethod(ref int x, int y)
    {
        x = x + x + y + y;
        Debug.Log($"Ref X is:{x}");
        return x;
    }

    int NoRefMethod(int x, int y)
    {
        x = x + x + y + y;
        Debug.Log($"NoRef X is:{x}");
        return x;
    }

    string OutMethod(bool x, char y, in string summary)
    {
        x = true;
        y = 'A';

        string debugMessage;
        string anotherSummary = y.ToString();
        debugMessage = $"{summary} + {y}";
        Debug.Log(debugMessage);
        Debug.Log(summary);

        return anotherSummary;
    }
}