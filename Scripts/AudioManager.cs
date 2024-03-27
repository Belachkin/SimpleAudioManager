using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    

    [SerializeField]
    private List<Sound> _sounds;

    private void Awake()
    {


        foreach(Sound sound in _sounds)
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
