using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Waypoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "VRAvatar") //might not need this check if nothing else has an RB.
        {                                        //RB also seems to not keep the isKinematic setting when pulling through the git repo so make sure to turn that on.
            Debug.Log("Collided: " + other.gameObject.name);
            SceneManager.Instance.CycleNextScene();
        }
        
    }
}
