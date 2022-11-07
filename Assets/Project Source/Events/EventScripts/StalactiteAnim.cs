using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteAnim : MonoBehaviour
{
    [SerializeField] private Animator AnimationControllerOne, AnimationControllerTwo, AnimationControllerThree, AnimationControllerFour, AnimationControllerFive;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Changes boolean to true to start animation
            AnimationControllerOne.SetBool("PlayStalactite", true);
            AnimationControllerTwo.SetBool("PlayStalactite", true);
            AnimationControllerThree.SetBool("PlayStalactite", true);
            AnimationControllerFour.SetBool("PlayStalactite", true);
            AnimationControllerFive.SetBool("PlayStalactite", true);
        }
    }
}
