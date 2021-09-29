using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTester : MonoBehaviour, IController
{
    //private InterfaceTester interfaceTester = new InterfaceTester();

    void MyTester(InterfaceTester interfaceTester)
    {
        interfaceTester.SpawnBall();
    }

    public void PrintStatus()
    {
        Debug.Log("Status unclear");
    }

    public void SpawnBall()
    {
        Debug.Log("Ball spawned!");
    }
}