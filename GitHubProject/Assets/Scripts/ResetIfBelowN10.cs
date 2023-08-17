using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetIfBelowN10 : MonoBehaviour
{
    void Start() => transform.position = new Vector3(0, -19, 3);
    
    void Update(){ if (transform.position.y <= -10) {transform.position = new Vector3(0, -19, 3);} }
}
