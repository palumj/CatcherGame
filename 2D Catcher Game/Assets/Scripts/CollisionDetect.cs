using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    private int points = 0;
    public Text score;

    private int life = 3;
    public Text lives;

    public AudioSource hitSound;
    public AudioSource missSound;
    public AudioClip hit;
    public AudioClip miss;

    void OnTriggerEnter2D(Collider2D other)
    {
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
}
