using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public GameObject menu;
    public GameObject exitButton;

    public AudioSource music;
    public AudioSource music2;
    public AudioSource hit;
    public AudioSource hit2;
    public AudioSource miss;
    public AudioSource miss2;

    public Text board1;
    public Text board2;
    public Text board3;
    public Text board4;
    public Text board5;
    public Text board6;
    public Text board7;
    public Text board8;
    public Text board9;
    public Text board10;



    private void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "WaitScene")
        {
            menu.SetActive(false);
            exitButton.SetActive(false);
        }

        //Updates high score board with saved scores
        board1.text = $"1. {PlayerPrefs.GetInt("HighScore1")}";
        board2.text = $"2. {PlayerPrefs.GetInt("HighScore2")}";
        board3.text = $"3. {PlayerPrefs.GetInt("HighScore3")}";
        board4.text = $"4. {PlayerPrefs.GetInt("HighScore4")}";
        board5.text = $"5. {PlayerPrefs.GetInt("HighScore5")}";
        board6.text = $"6. {PlayerPrefs.GetInt("HighScore6")}";
        board7.text = $"7. {PlayerPrefs.GetInt("HighScore7")}";
        board8.text = $"8. {PlayerPrefs.GetInt("HighScore8")}";
        board9.text = $"9. {PlayerPrefs.GetInt("HighScore9")}";
        board10.text = $"10. {PlayerPrefs.GetInt("HighScore10")}";
    }

    private void Update()
    {//Handling user input to switch scenes
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameplayScene");
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("WaitScene");
        }
    }
}
