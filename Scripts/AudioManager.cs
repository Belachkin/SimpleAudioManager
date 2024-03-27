using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public List<Sound> sounds;

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
        Sound s = sounds.Find(x => x.Name == name);
        s.Source.Play();
    }
}
