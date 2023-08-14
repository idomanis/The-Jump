using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private PlayerInput PL;
    private PlayerInput.OnFootActions onfoot;

    private Player_Movement move;

    void Start()
    {
        PL = new PlayerInput();
        onfoot = PL.OnFoot;
        move = GetComponent<Player_Movement>();
        onfoot.Jump.performed += ctx => move.Jump();
        onfoot.Sprint.started += ctx => move.Sprint(true);
        onfoot.Sprint.canceled += ctx => move.Sprint(false);
    }

    void Update()
    {
        if (transform.position.y < -10) {SceneManager.LoadScene(0);}
    }
}
