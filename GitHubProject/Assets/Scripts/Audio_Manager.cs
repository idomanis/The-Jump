using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour
{
    [SerializeField] private AudioSource FFL, LHO, L, Weeee;
    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag)
        {
            case "Trash":
                L.Play();
                break;
            case "Barrel":
                LHO.Play();
                break;
            case "Clock":
                Weeee.Play();
                break;
            case "FreeNope":
                FFL.Play();
                break;
        }
    }
}
