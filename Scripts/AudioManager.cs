using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach(Sound sound in sounds)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();

            sound.Initialization();
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        s.Source.Play();
    }
}
