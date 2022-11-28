using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource MusicSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioSource clip, int delay)
    {
        clip.PlayDelayed(delay);
    }

    public void SwitchSong(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}
