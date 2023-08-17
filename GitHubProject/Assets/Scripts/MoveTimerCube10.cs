using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTimerCube10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() => transform.position = new Vector3(-100, 7.5f, 0);

    // Update is called once per frame
    void FixedUpdate() => transform.Translate(0.01f, 0, 0);
}
