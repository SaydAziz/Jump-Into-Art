using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteAnim : MonoBehaviour
{
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["TestOneFallV.5"].layer = 123;
    }

    //double the fall speed when true
    private bool fastFall = false;

    // Update is called once per frame
    void Update()
    {

        
        //Leave first stalactite to fall to complete before changing
        if(anim.isPlaying)
        {
            return;
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Test One Falling");
            anim.Play("TestOneFallV.5");
        }
    }
}
