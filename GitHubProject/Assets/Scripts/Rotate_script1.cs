using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_script1 : MonoBehaviour
{
    private int rot = 360;
    void Update()
    {
        transform.rotation = Quaternion.Euler(45, rot, 45);
        rot -= 1;
        if (rot < 0) {rot += 360;}
    }
}
