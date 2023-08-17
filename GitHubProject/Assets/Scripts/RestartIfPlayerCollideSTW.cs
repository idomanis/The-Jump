using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartIfPlayerCollideSTW : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {if(other.gameObject.tag == "Player"){other.transform.position = new Vector3(0, -10, 0);}}
}