using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.Core;
using Liminal.Core.Fader;
public class EndExperience : MonoBehaviour
{

    private int fadeDuration = 10;

    private void OnTriggerEnter(Collider other)
    { 
    
        var fader = ScreenFader.Instance;
        fader.FadeTo(Color.black, fadeDuration);

       // ExperienceApp.End();
    }
}
