using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    private PlayerInput PL;
    private PlayerInput.OnFootActions OF;
    private CharacterController cc;
    private Vector3 playerVel;
    private bool isGrounded;
    [SerializeField]
    private float gravity = -15f;

    [SerializeField]
    private float jumpHeight = 1.3f;

    [SerializeField]
    private float Speed = 5f;

    void Start() => cc = GetComponent<CharacterController>();

    void Awake()
    {
        PL = new PlayerInput();
        OF = PL.OnFoot;
    }

    // Update is called once per frame
    void Update() {isGrounded = cc.isGrounded;}

    public void ProcessMovement(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = input.x;
        moveDir.z = input.y;
        cc.Move(transform.TransformDirection(moveDir) * Speed * Time.deltaTime);
        playerVel.y += gravity * Time.deltaTime;
        if (isGrounded && playerVel.y < 0) {playerVel.y = -5f;}
        cc.Move(playerVel * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVel.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    public void Sprint(bool sprinting)
    {
        if (sprinting) {Speed = 10;}
        else if(!sprinting) {Speed = 5;}
    }
}
