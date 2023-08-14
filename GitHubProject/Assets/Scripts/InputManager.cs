using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput PL;
    private PlayerInput.OnFootActions onfoot;

    private Player_Movement move;
    private Player_Look l;

    void Awake()
    {
        PL = new PlayerInput();
        onfoot = PL.OnFoot;
        move = GetComponent<Player_Movement>();
        onfoot.Jump.performed += ctx => move.Jump();
        onfoot.Sprint.started += ctx => move.Sprint(true);
        onfoot.Sprint.canceled += ctx => move.Sprint(false);
        l = GetComponent<Player_Look>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move.ProcessMovement(onfoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        l.ProcessLook(onfoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable() => onfoot.Enable();
    private void OnDisable() => onfoot.Disable();
}
