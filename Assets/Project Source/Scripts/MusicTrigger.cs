using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    [SerializeField] AudioClip Song;
    private void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.SwitchSong(Song);
    }
}