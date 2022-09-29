using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Waypoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "VRAvatar") //might not need this check if nothing else has an RB
        {
            Debug.Log("Collided: " + other.gameObject.name);
            SceneManager.Instance.CycleNextScene();
        }
        
    }
}
