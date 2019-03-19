using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    public AudioSource music;
    public AudioSource music2;
    public AudioSource hit;
    public AudioSource hit2;
    public AudioSource miss;
    public AudioSource miss2;

    public AudioClip hitC;
    public AudioClip missC;

    public Slider musicControl;
    public Slider SFX;

    private void Start()
    {//Updates volume levels based on PlayerPrefs (the default value is 1.0f)
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "WaitScene")
        {//I tried to make sure the music did not duplicate, but my solutions did not seem to work consistently...
            if (!music.isPlaying && !music2.isPlaying)
            {
                music2 = Instantiate(music);
                music2.Play();
                DontDestroyOnLoad(music2);
            }
            musicControl.value = music2.volume;
        }

        hit2 = Instantiate(hit);
        miss2 = Instantiate(miss);
        //SFX.value = hit2.volume;

        DontDestroyOnLoad(hit2);
        DontDestroyOnLoad(miss2);

        music2.volume = PlayerPrefs.GetFloat("Music", 1.0f);
        hit2.volume = PlayerPrefs.GetFloat("SFX1", 1.0f);
        miss2.volume = PlayerPrefs.GetFloat("SFX2", 1.0f);
        PlayerPrefs.Save();
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {//Handling collisions with the player and the bottom of the screen
        if (gameObject.name == "Player Object")
        {
            hit.PlayOneShot(hitC);
        }

        if (gameObject.name == "Destroy Collider")
        {
            miss.PlayOneShot(missC);
        }
    }*/

    //Two functions below handle changing volume levels based on slider input by user
    public void OnMusicChanged()
    {
        music2.volume = musicControl.value;
        PlayerPrefs.SetFloat("Music", music2.volume);
        PlayerPrefs.Save();
    }

    public void OnSFXChanged()
    {
        hit2.volume = SFX.value;
        miss2.volume = SFX.value;
        PlayerPrefs.SetFloat("SFX1", hit2.volume);
        PlayerPrefs.SetFloat("SFX2", miss2.volume);
        PlayerPrefs.Save();
    }

    public void Mute()
    {
        music2.mute = true;
        hit2.mute = true;
        miss2.mute = true;
    }

    public void Unmute()
    {
        music2.mute = false;
        hit2.mute = false;
        miss2.mute = false;
    }

    private void Update()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "LoseScene")
        {
            music2.Stop();
        }
    }
}
