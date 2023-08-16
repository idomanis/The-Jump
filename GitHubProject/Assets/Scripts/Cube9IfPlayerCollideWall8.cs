using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube9IfPlayerCollideWall8 : MonoBehaviour
{
    [SerializeField] private GameObject Cube9;
    void Start()
    {
        Cube9.transform.position = new Vector3(11.6f, 12.44f, -3.95f);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") 
        {
            Cube9.transform.position = new Vector3(11f, 6, -3);
        }
    }
}
