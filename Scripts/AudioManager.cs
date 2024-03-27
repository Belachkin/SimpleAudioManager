using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField]
    private List<Sound> _sounds;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance == this)
        {
            Destroy(gameObject);
        }

        Initialization();
    }

    private void Initialization()
    {
        foreach (Sound sound in _sounds)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();

            sound.Initialization();
        }
    }

    public void Play(string name)
    {
        Sound s = _sounds.Find(x => x.Name == name);
        s.Source.Play();
    }
}
