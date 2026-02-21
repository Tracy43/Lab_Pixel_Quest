using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string one = "Hello";
    int var = 0;
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("Hello World");
        string two = "World";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { transform.position += new Vector3(0, 1, 0); }
        var++;
        Debug.Log(var);

    }
}
