using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumsTest : MonoBehaviour
{
    enum Sneakers
    {
        Adidas = 2,
        Reebok = 4,
        Vans = 8,
        Puma = 16
    }

    Sneakers sneak;

    void OnSwitch()
    {
        switch (sneak)
        {
            case Sneakers.Adidas:
                Debug.Log("It's Adidas!");
                break;
            case Sneakers.Reebok:
                Debug.Log("It's Reebok!");
                break;
            case Sneakers.Vans:
                Debug.Log("It's Vans!");
                break;
            case Sneakers.Puma:
                Debug.Log("It's Puma!");
                break;
        }
        
        Debug.Log((int)sneak);
    }

    // Start is called before the first frame update
    void Start()
    {
        sneak = Sneakers.Reebok;
        
        OnSwitch();
        
        sneak = Sneakers.Adidas;
        
        OnSwitch();

       
    }

    // Update is called once per frame
    void Update()
    {
    }
}