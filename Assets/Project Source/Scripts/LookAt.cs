using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
