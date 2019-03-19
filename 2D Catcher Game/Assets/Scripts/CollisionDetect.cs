using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    private int points = 0;
    public Text score;

    int[] highScores = new int[10];
    string highScoreKey = "";

    private int life = 3;
    public Text lives;

    public AudioSource hitSound;
    public AudioSource missSound;
    public AudioClip hit;
    public AudioClip miss;

    void OnTriggerEnter2D(Collider2D other)
    {//Handling collisions with the player and the bottom of the screen
        if (gameObject.name == "Player Object")
        {
            points += 10;
            score.text = $"Score: {points}";
            Destroy(other.gameObject);
            hitSound.PlayOneShot(hit);
        }

        if (gameObject.name == "Destroy Collider")
        {
            life -= 1;
            lives.text = $"Lives: {life}";
            Destroy(other.gameObject);
            missSound.PlayOneShot(miss);
        }
    }

    private void FixedUpdate()
    {
        if (life == 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    private void Awake()
    {
        score.text = $"Score: {points}";
        lives.text = $"Lives: {life}";
    }

    void OnDisable()
    {
        for (int i = 0; i < highScores.Length; i++)
        {//Retrieves the score saved in each of 10 spots - creates key if it doesn't exist
            highScoreKey = "HighScore" + (i + 1).ToString();
            int highScore = PlayerPrefs.GetInt(highScoreKey, 0);
            PlayerPrefs.Save();

            //if the current number of points scored is higher than the score saved in a spot, the high score is updated
            if (points > highScores[i])
            {
                int temp = highScore;
                PlayerPrefs.SetInt(highScoreKey, points);
                PlayerPrefs.Save();
                points = temp;
            }
        }
    }
}
