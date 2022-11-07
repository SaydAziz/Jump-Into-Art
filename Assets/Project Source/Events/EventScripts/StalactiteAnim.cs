using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteAnim : MonoBehaviour
{
    private Animation anim;
    [SerializeField] string eventName = "Stalactite Event";

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }


    // Update is called once per frame
    void Update()
    {
        

    }
}
