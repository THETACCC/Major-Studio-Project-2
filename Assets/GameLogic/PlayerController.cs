using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 10f;
    public float detectForce = 100f;
    public float maxSpeed = 10f;
    public float turnSpeed = 100f;


    private Rigidbody rb;
    private float TimeSinceLastPress = 0f;
    private bool startCounting = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("No Rigidbody component found on this object.");
        }
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            MoveForward();
        }

        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp(KeyCode.H) || Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.K) || Input.GetKeyUp(KeyCode.L))
        {
            startCounting = true;
        }

        if (startCounting)
        {
            TimeSinceLastPress += Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.S) && (!Input.GetKey(KeyCode.A)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress)  , ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.D) && (!Input.GetKey(KeyCode.S))) 
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.F) && (!Input.GetKey(KeyCode.D)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.G) && (!Input.GetKey(KeyCode.F)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.H) && (!Input.GetKey(KeyCode.G)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.J) && (!Input.GetKey(KeyCode.H)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }
        if (Input.GetKey(KeyCode.K) && (!Input.GetKey(KeyCode.J)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }
        if (Input.GetKey(KeyCode.L) && (!Input.GetKey(KeyCode.K)))
        {
            rb.AddForce(transform.forward * (detectForce / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }


        if (Input.GetKey(KeyCode.Z))
        {
            TurnLeft();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            TurnRight();
        }


        ClampSpeed();


    }
    void ClampSpeed()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    void MoveForward()
    {
        //rb.velocity = Vector3.forward * moveForce;
        rb.AddForce(transform.forward * moveForce, ForceMode.Acceleration);
    }

    // Function to turn the object left
    void TurnLeft()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, -turnSpeed * Time.deltaTime, 0f));
    }

    // Function to turn the object right
    void TurnRight()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, turnSpeed * Time.deltaTime, 0f));
    }


}
