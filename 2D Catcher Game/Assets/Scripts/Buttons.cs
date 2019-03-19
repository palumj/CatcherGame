using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Button quitGame;
    public Button menuButton;
    public Button exitButton;

    public GameObject menu;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        menu.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }

    public void ExitMenu()
    {
        menu.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }
}
