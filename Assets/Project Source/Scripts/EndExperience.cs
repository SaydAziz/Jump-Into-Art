using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.Core;
using Liminal.Core.Fader;
public class EndExperience : MonoBehaviour
{

    private int fadeDuration = 1;

    public float TimeLeft;
    public bool TimerOn = false;

    private void Start()
    {
        TimerOn = true;
    }

    private void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Screen Fade time is up.");
                TimeLeft = 0;
                TimerOn = false;

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
