using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_script : MonoBehaviour
{
    private int rot = 0;
    void Update()
    {
        transform.rotation = Quaternion.Euler(45, rot, 45);
        rot += 2;
        if (rot > 359) {rot = 0;}
    }
}
