using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    Vector2 StartPos, EndPos, direction, pos;              // Start position, end position, swipe direction

    float TouchTimeStart, TouchTimeFinish, Timeinterval;          //Calculate swipe time

    [SerializeField]
    float ThrowForceXY = 1f;
    [SerializeField]
    float ThrowForceZ = 100f;
    Rigidbody rb;

     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        TouchTimeStart = Time.time;
        StartPos = Input.mousePosition;
        StartPos = Camera.main.ScreenToWorldPoint(StartPos); 
    }

    private void OnMouseUp()
    {
        TouchTimeFinish = Time.time;
        Timeinterval = TouchTimeFinish - TouchTimeStart;
        EndPos = Input.mousePosition;
        direction = StartPos - EndPos;
        rb.isKinematic = false;
        rb.AddForce(-direction.x * ThrowForceXY, -direction.y * ThrowForceXY * 1f, ThrowForceZ / Timeinterval * 2f);
        InvokeRepeating("ReturnBall", 5, 20);
    }
    void ReturnBall()
    {
        rb.isKinematic = true;
        transform.position = new Vector3(0.0f, -0.09f, 0.0f) ;
        rb.velocity = Vector3.zero;
    }

}
