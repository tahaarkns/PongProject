using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;
    public float upperBoundY = 2.5f; 
    public float lowerBoundY = -3.5f; 

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Movement()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
            vel.y = speed;
        else if (Input.GetKey(moveDown))
            vel.y = -speed;
        else
            vel.y = 0;
        rb2d.velocity = vel;
    }

    private void Boundaries()
    {
        var pos = transform.position;
        if (pos.y > upperBoundY)
            pos.y = upperBoundY;
        else if (pos.y < lowerBoundY)
            pos.y = lowerBoundY;
        transform.position = pos;
    }

    void Update()
    {
        Movement();
        Boundaries();
    }
}
