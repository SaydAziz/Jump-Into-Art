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

    public void PlaySound(AudioSource clip)
    {
        clip.Play();
    }

    public void SwitchSong(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}
