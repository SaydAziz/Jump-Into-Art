﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierFollow : MonoBehaviour
{
    [SerializeField]
    private Transform[] routes;

    private int routeToGo;

    private float tParam;

    private Vector3 objectPosition;

    private float speedModifier;

    private bool coroutineAllowed;

    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tParam = 0f;
        speedModifier = 0.5f;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
        }
    }

    private IEnumerator GoByTheRoute(int routeNum)
    {
        coroutineAllowed = false;

        Vector3 p0 = routes[routeNum].GetChild(0).position;
        Vector3 p1 = routes[routeNum].GetChild(1).position;
        Vector3 p2 = routes[routeNum].GetChild(2).position;
        Vector3 p3 = routes[routeNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0;
        speedModifier = speedModifier * 0.90f;
        routeToGo += 1;

        if (routeToGo > routes.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;

    }
}
