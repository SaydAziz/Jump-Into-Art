using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleEventSpawn : MonoBehaviour
{
    //Trigger Event

    //Variable to Hold Animation Controller
    [SerializeField] private Animator MyAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Changes boolean to true to start animation
            MyAnimationController.SetBool("PlayWhale", true);
        }
       
    }




}
