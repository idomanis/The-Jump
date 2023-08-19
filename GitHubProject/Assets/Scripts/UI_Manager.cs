using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public void UI_Start() => SceneManager.LoadScene(1);

    public void UI_Quit() => Application.Quit();
}
