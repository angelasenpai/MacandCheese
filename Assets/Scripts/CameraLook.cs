using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    float mouseX, mouseY;

    public float sensitivity = 100;

    Transform playerBody;

    float xRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GameObject.Find("Player").transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        //pitch
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90,90);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //yaw
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
