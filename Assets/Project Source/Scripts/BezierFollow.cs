using System.Collections;
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

    private Transform spawnPoint;
    private Transform playerPosition;
    private Transform gameSpawn;

    [SerializeField]
    private GameObject boat;
    

    [SerializeField]
    private bool isMoving;

    // Time script
    public float TimeLeft;
    public bool TimerOn = false;


    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
        routeToGo = 0;
        tParam = 0f;
        speedModifier = 0.1f;
        coroutineAllowed = false;
        isMoving = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);

                coroutineAllowed = false;
            }
            else
            {
                Debug.Log("Time is up, transition spawn");
                TimeLeft = 0;
                TimerOn = false;
                boat.SetActive(true);
                coroutineAllowed = true; 
            }
        }

        if (coroutineAllowed == true)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
            isMoving = true;
        }
        if (coroutineAllowed == false)
        {
            isMoving = false;
        }

    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
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

        /*if (routeToGo > routes.Length - 1)
        {
            routeToGo = 0;
        }*/ //commented this out so that the avatar doesn't go back to the beginning of the routes again


        coroutineAllowed = true;

    }
}
