using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    float speed = 12;
    float gravity = -9.8f;

    Vector3 velocity;

    [SerializeField] private Transform groundCheck;
   float groundDistance = 0.5f;
    [SerializeField] private LayerMask groundMask;

    bool isGrounded;

    public float jumpHeight = 3;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
       // groundCheck = GameObject.Find("groundCheck").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //create a sphere and if sphere is colliding with anything in the ground mask then isGrounded is true
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y <0)
        {
            velocity.y = -2;
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight*gravity*-2);
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        Vector3 move = transform.right * x + transform.forward*z;
        controller.Move(move*speed*Time.deltaTime);

    }
 }
