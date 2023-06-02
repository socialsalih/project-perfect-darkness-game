using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Animation and Rotation (Look) floats
    // static Animator anim;

    public float rotationSpeed = 75.0f;

    //walking speed
    public float walkSpeed;

    //jumping speed
    public float jumpForce;

    //coin playing sound
    public AudioSource coinSound;

    //Rigidbody component
    Rigidbody rb;

    //Collider component
    BoxCollider col;

    //flag to keep track of key pressing
    bool pressedJump = false;

    //size of the player
    Vector3 size;

    // Use this for initialization
    void Start()
    {


        //Grab the animator component to make him walk
        //anim = GetComponent<Animator>();

        //Grab our component
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();

        //Get player size
        size = col.bounds.size;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        WalkHandler();
        //   JumpHandler();
    }
    //takes care of the walking logic
    void WalkHandler()

    {

        //Input on x (Horizontal)
        float hAxis = (Input.GetAxis("Vertical"));


        //Input on z (Vertical)
        float vAxis = Input.GetAxis("Horizontal");

        //Movement vector
        Vector3 movement = new Vector3(-(hAxis) * walkSpeed * Time.deltaTime, 0, vAxis * walkSpeed * Time.deltaTime);

        //Calculate the new position

        Vector3 newPos = transform.position + movement;



        //Move
        rb.MovePosition(newPos);



        //rotate and look in the proper direction

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;


        if (movement != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
    }
}