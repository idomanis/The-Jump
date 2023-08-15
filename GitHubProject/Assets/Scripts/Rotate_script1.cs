using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate_script1 : MonoBehaviour
{
    private float rot = 360;
    private float rotChange = 1;
    private float x = 1.01f;
    void Update()
    {
        transform.rotation = Quaternion.Euler(45, rot, 45);
        rot -= rotChange;
        rotChange *= x;
        if (rotChange >= 5) {x -= 0.02f;}
        if (rotChange <= 1) {x += 0.02f;}
        if (rot < 0) {rot += 360;}
        if (rot >= 360) {rot -= 360;}
    }
}
