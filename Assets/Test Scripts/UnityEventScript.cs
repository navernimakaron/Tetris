using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventScript : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;

    private RosaVentorum _compass;

    enum RosaVentorum
    {
        East,
        South,
        North,
        West
    }

    void OutputMessage()
    {
        RosaVentorum compass;
        compass = RosaVentorum.West;
        Debug.Log(compass);
        Debug.Log(_compass == RosaVentorum.East);
        switch (_compass)
        {
            case RosaVentorum.East:
                Debug.Log("East!");
                break;
            case RosaVentorum.South:
                Debug.Log("South!");
                break;
            case RosaVentorum.West:
                Debug.Log("West!");
                break;
            case RosaVentorum.North:
                Debug.Log("North!");
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        _event.Invoke();
        OutputMessage();
        
       
    }
}