using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector3 mouseOffset;
    float mouseZcoord;

    Rigidbody rb;

    //use rigid body instead of position

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mouseZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - getWorldPos();
    }
    Vector3 getWorldPos()
    {
        //pixel coordinates
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game object on screen
        mousePoint.z = mouseZcoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
    void OnCollisionEnter(Collision col)
    {
        // Freeze on collision
        //rb.isKinematic = true;
    }
    private void OnMouseDrag()
    {
        rb.MovePosition(getWorldPos() + mouseOffset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
