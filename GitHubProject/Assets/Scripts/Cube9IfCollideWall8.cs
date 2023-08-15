using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube9IfCollideWall8 : MonoBehaviour
{
    [SerializeField] private GameObject Cube9;
    void Start() => Cube9.transform.position = new Vector3(13, 9, -4);
    void OnCollisionEnter(Collision other) { if(other.gameObject.tag == "Wall8") {Cube9.transform.position = new Vector3(11.55f, 16, -3);}}
}
