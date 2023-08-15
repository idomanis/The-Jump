using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube9IfPlayerCollideWall8 : MonoBehaviour
{
    [SerializeField] private GameObject Cube9;
    void Start() => Cube9.transform.position = new Vector3(11.6f, 11.94f, -3.95f);
    void OnCollisionEnter(Collision other) { if(other.gameObject.tag == "Player") {Cube9.transform.position = new Vector3(11f, 16, -3);}}
}
