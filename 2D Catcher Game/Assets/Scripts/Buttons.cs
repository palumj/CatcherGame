using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Button quitGame;

    public void QuitGame()
    {
        Application.Quit();
    }
}
