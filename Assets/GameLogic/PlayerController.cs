using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 10f;
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

        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S))
        {
            startCounting = true;
        }

        if (startCounting)
        {
            TimeSinceLastPress += Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.S) && (!Input.GetKey(KeyCode.A)));
        {
            rb.AddForce(transform.forward * (10f / TimeSinceLastPress)  , ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }

        if (Input.GetKey(KeyCode.D) && (!Input.GetKey(KeyCode.S))) ;
        {
            rb.AddForce(transform.forward * (10f / TimeSinceLastPress), ForceMode.Force);
            startCounting = false;
            TimeSinceLastPress = 0;
        }


    }


    void MoveForward()
    {

        rb.AddForce(transform.forward * moveForce, ForceMode.Force);
    }
}
