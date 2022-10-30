using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPositionScript : MonoBehaviour
{
    public Transform dummyTransform;
    //Vector3 lastPosition;
    void Start()
    {
        dummyTransform.parent = transform;
        //lastPosition = transform.position;
    }
    void Update()
    {
        //Vector3 difference = transform.position - lastPosition;
        dummyTransform.position = transform.position;
        //lastPosition = transform.position;
    }

}
