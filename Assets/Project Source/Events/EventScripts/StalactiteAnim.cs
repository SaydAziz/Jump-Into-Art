using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteAnim : MonoBehaviour
{
    [SerializeField] private Animator MyAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Changes boolean to true to start animation
            MyAnimationController.SetBool("S_AnimOne", true);
            MyAnimationController.SetBool("S_AnimTwo", true);
            MyAnimationController.SetBool("S_AnimThree", true);
            MyAnimationController.SetBool("S_AnimFour", true);
            MyAnimationController.SetBool("S_AnimFive", true);
        }
    }
}
