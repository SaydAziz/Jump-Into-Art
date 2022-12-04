using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    //Trigger Event

    //Variable to Hold Animation Controller
    [SerializeField] private Animator AnimController;
    [SerializeField] private ParticleSystem Particles;
    [SerializeField] private AudioSource clip;
    [SerializeField] private int soundDelay;

    private void OnTriggerEnter(Collider other)
    {
        if (AnimController != null)
        {
            AnimController.SetBool("isPlaying", true);
        }
        else
        {
            Particles.Play();
        }

        SoundManager.Instance.PlaySound(clip, soundDelay);

    }




}
