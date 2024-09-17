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


    private float TimeSinceLastPressLeft = 0f;
    private bool startCountingLeft = false;
    private float TurnLeftCounter = 0f;
    public  float TurnModify = 1f;

    private float TimeSinceLastPressRight = 0f;
    private bool startCountingRight = false;
    private float TurnRightCounter = 0f;


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


        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyUp(KeyCode.X) || Input.GetKeyUp(KeyCode.C) || Input.GetKeyUp(KeyCode.V) || Input.GetKeyUp(KeyCode.B) || Input.GetKeyUp(KeyCode.N) || Input.GetKeyUp(KeyCode.M))
        {
            TurnLeft();
            startCountingLeft = true;
        }


        if (Input.GetKeyDown(KeyCode.X) && (!Input.GetKey(KeyCode.Z)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if(TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;
  
            TimeSinceLastPressLeft = 0;

        }
        if (Input.GetKeyDown(KeyCode.C) && (!Input.GetKey(KeyCode.X)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if (TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;

            TimeSinceLastPressLeft = 0;

        }
        if (Input.GetKeyDown(KeyCode.V) && (!Input.GetKey(KeyCode.C)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if (TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;

            TimeSinceLastPressLeft = 0;

        }
        if (Input.GetKeyDown(KeyCode.B) && (!Input.GetKey(KeyCode.V)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if (TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;

            TimeSinceLastPressLeft = 0;

        }
        if (Input.GetKeyDown(KeyCode.N) && (!Input.GetKey(KeyCode.B)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if (TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;

            TimeSinceLastPressLeft = 0;

        }
        if (Input.GetKeyDown(KeyCode.M) && (!Input.GetKey(KeyCode.N)))
        {
            TurnLeftCounter = TurnModify / TimeSinceLastPressLeft;
            if (TurnLeftCounter >= 0.2f)
            {
                TurnLeftCounter = 0.2f;
            }
            startCountingLeft = false;

            TimeSinceLastPressLeft = 0;

        }
        if (TurnLeftCounter >= 0)
        {
            Debug.Log(TurnLeftCounter);
            TurnLeft();
            TurnLeftCounter -= Time.deltaTime; 
        }


        if (startCountingLeft)
        {
            TimeSinceLastPressLeft += Time.deltaTime;
        }






        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P))
        {
            TurnRight();
            startCountingRight = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && (!Input.GetKey(KeyCode.Q)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.E) && (!Input.GetKey(KeyCode.W)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.R) && (!Input.GetKey(KeyCode.E)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.T) && (!Input.GetKey(KeyCode.R)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.Y) && (!Input.GetKey(KeyCode.T)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.U) && (!Input.GetKey(KeyCode.Y)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.I) && (!Input.GetKey(KeyCode.U)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.O) && (!Input.GetKey(KeyCode.I)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }
        if (Input.GetKeyDown(KeyCode.P) && (!Input.GetKey(KeyCode.O)))
        {
            TurnRightCounter = TurnModify / TimeSinceLastPressRight;
            if (TurnRightCounter >= 0.2f)
            {
                TurnRightCounter = 0.2f;
            }
            startCountingRight = false;

            TimeSinceLastPressRight = 0;

        }



        if (TurnRightCounter >= 0)
        {
            Debug.Log(TurnRightCounter);
            TurnRight();
            TurnRightCounter -= Time.deltaTime;
        }


        if (startCountingRight)
        {
            TimeSinceLastPressRight += Time.deltaTime;
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

    void TurnLeft()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, -turnSpeed * Time.deltaTime, 0f));
    }


    void TurnRight()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, turnSpeed * Time.deltaTime, 0f));
    }


}
