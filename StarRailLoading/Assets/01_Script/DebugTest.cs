using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{

    int number1;
    int number2;

    void Awake()
    {
        number1 = 1;
        number2 = 2;
    }

    void OnEnable()
    {
        number1 += 1;
    }

    void Start()
    {
        number1 = number2;
    }

    void Update()
    {
        if(number1 == number2)
        {
            UnityEngine.Debug.Log("같다!");
            number1++;
        }
        else
        {
            UnityEngine.Debug.Log("다르다!");
            number1 = number2;
        }
    }
}
