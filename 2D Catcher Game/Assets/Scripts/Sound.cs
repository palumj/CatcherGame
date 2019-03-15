using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource music;
    public AudioSource hit;
    public AudioSource miss;

    public void Mute()
    {
        music.mute = true;
        hit.mute = true;
        miss.mute = true;
    }

    public void Unmute()
    {
        music.mute = false;
        hit.mute = false;
        miss.mute = false;
    }
}
