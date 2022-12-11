﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.Core;
using Liminal.Core.Fader;
public class StartFadeToBlack : MonoBehaviour
{

    private int fadeDuration = 1;

    public float FadeToBlackTimeLeft;
    public bool FadeToBlackTimerOn = false;

    private void Start()
    {
        FadeToBlackTimerOn = true;
    }

    private void Update()
    {
        if (FadeToBlackTimerOn)
        {
            if (FadeToBlackTimeLeft > 0)
            {
                FadeToBlackTimeLeft -= Time.deltaTime;
                updateTimer(FadeToBlackTimeLeft);
            }
            else
            {
                Debug.Log("Screen Fade time is up.");
                FadeToBlackTimeLeft = 0;
                FadeToBlackTimerOn = false;

                var fader = ScreenFader.Instance;
                fader.FadeTo(Color.black, fadeDuration);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
    }

}
