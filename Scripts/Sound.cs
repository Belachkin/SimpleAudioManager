using System;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound 
{
    public string Name;
    public AudioClip Clip;

    [Range(0f, 1f)]
    public float Volume = 0.5f;
    [Range(0.1f, 3f)]
    public float Pitch = 1f;

    [HideInInspector]
    public AudioSource Source;

    public void Initialization()
    {
        Source.volume = Volume;
        Source.pitch = Pitch;
        Source.clip = Clip;
    }
}
