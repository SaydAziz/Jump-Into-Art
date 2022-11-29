using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGeyser : MonoBehaviour
{
    [SerializeField] private ParticleSystem Geyser;
    [SerializeField] private AudioSource clip;
    [SerializeField] private int soundDelay;

    private void OnTriggerEnter(Collider other)
    {
        Geyser.Play(Geyser);
        SoundManager.Instance.PlaySound(clip, soundDelay);
    }
}
