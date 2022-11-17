using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPause : MonoBehaviour
{
    public delegate void PublishPause();
    public static event PublishPause Pause;
    public static event PublishPause Resume;

    private bool isPaused;
    // Start is called before the first frame update

    void PublishEvent()
    {
        if (isPaused)
        {
            Resume?.Invoke();
        }
        else
        {
            Pause?.Invoke();
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            PublishEvent();
        }
    }
}
