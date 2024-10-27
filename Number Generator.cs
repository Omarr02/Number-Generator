using System;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    void Start()
    {
        System.Random random = new System.Random();
        int number;
        while (true)
        {
            number = random.Next(1, 21); 
            if (number == 5)
            {
                continue; 
            }
            if (number == 15)
            {
                break; 
            }
            Debug.Log(number);
        }
    }
}

