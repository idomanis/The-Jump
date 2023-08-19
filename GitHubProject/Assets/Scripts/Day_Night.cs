using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night : MonoBehaviour
{
    private float x = 0;
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float y = x/12000;
        transform.rotation = Quaternion.Euler(y, 0, 0);
        x++;
    }
}
