using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteAnim : MonoBehaviour
{
    [SerializeField] private Animator AnimationController;


    private void OnTriggerEnter(Collider other)
    {
        float fall = Input.GetAxis("Vertical");
        AnimationController.SetFloat("Speed", fall);

        if (other.CompareTag("Player"))
        {
            //Changes boolean to true to start animation
            AnimationController.SetBool("PlayStalactite", true);
        }

    }
}
