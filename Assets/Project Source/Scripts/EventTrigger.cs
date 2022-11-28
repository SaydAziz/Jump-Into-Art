﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    //Trigger Event

    //Variable to Hold Animation Controller
    [SerializeField] private Animator MyAnimationController;
    [SerializeField] private AudioSource clip;
    [SerializeField] private int soundDelay;

    private void OnTriggerEnter(Collider other)
    {
            //Changes boolean to true to start animation
            MyAnimationController.SetBool("isPlaying", true);
            SoundManager.Instance.PlaySound(clip, soundDelay);
       
    }




}
