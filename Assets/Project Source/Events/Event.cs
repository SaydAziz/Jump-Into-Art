using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Time difference for all three categories for the stalactites to fall.
    // To get the stalactite to fall after the player reaches a waypoint they will fall in intervals based on the gameObjects name.
    float testOneTime;
    public GameObject TestOne;
    private Rigidbody rb;

    float testTwoTime;
    public GameObject TesTwo;

    float testThreeTime;
    public GameObject TestThree;

    public bool useGravity = true; 

    


    //For testing purposes this is the player speed
    private float speed = 5.0f;
    private float horizontalInput;
    private float VerticalInput;
    private float backwardsSpeed = -5.0f;
    public GameObject player;

    bool Collision = false;


    // Delay for the time it takes for the event to start.
    void Delay()
    {

    }

    void StartEvent()
    {
        
    }

    void EndEvent()
    {

    }

    void PauseEvent()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Waypoint")
        {
            Debug.Log("The player has reached the waypoint.");

            //TestOne.Rigidbody.useGravity = false;

            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            // Moves player
            transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Moves player
            transform.Translate(Vector3.back * Time.deltaTime * backwardsSpeed * VerticalInput);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Moves player
            transform.Translate(Vector3.left * Time.deltaTime * backwardsSpeed * horizontalInput); 
        }

        
    }
}
