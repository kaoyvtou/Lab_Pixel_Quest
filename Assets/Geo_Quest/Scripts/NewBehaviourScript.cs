using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string String = "Hello";
    int IntegerA = 727;

    // Start is called before the first frame update
    void Start()
    {
        string String2 = " World";
        Debug.Log("Hello World");
        Debug.Log(String + String2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IntegerA);
        IntegerA++;
    }
}
