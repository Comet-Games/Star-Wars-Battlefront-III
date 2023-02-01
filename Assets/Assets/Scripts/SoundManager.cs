using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioListener AudioListener;
    public AudioClip[] menuSounds;

    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }


}
