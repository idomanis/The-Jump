using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Look : MonoBehaviour
{
    public Camera cam;
    private float xRot = 0f;

    [SerializeField]
    private float xSen = 30f;
    
    [SerializeField]
    private float ySen = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        //calculate camera X and Y
        xRot -= mouseY * Time.deltaTime * ySen;
        xRot = Mathf.Clamp(xRot, -80f, 80f);

        //apply calc to cam transform
        cam.transform.localRotation = Quaternion.Euler(xRot, 0, 0);

        //rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSen);
    }
}
