using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string one = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string two = "World";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello" + "World");
    }
}
