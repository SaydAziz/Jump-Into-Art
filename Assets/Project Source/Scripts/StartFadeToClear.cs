using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.Core;
using Liminal.Core.Fader;
public class StartFadeToClear : MonoBehaviour
{

    private int fadeDuration = 1;

    public float FadeToClearTimeLeft;
    public bool FadeToClearTimerOn = false;
    [SerializeField] private AudioSource clip;
    [SerializeField] private int soundDelay;

    private void Start()
    {
        FadeToClearTimerOn = true;

        if (clip != null)
        {
            
        }
        else
        {
            clip = null;
        }
    }

    private void Update()
    {
        if (FadeToClearTimerOn)
        {
            if (FadeToClearTimeLeft > 0)
            {
                FadeToClearTimeLeft -= Time.deltaTime;
                updateTimer(FadeToClearTimeLeft);
            }
           
            else
            {
                Debug.Log("Screen Fade time is up.");
                FadeToClearTimeLeft = 0;
                FadeToClearTimerOn = false;
                SoundManager.Instance.PlaySound(clip, soundDelay);

                var fader = ScreenFader.Instance;
                fader.FadeTo(Color.clear, fadeDuration);
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
