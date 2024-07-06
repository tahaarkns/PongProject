using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Transform ball;
    public float speed = 10f; 
    public float upperBoundY = 2.5f;
    public float lowerBoundY = -3.5f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePaddle();
        ClampPaddlePosition();
    }

    void MovePaddle()
    {
        
        Vector2 targetPosition = new Vector2(transform.position.x, ball.position.y);
        Vector2 newPosition = Vector2.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        rb2d.MovePosition(newPosition);
    }

    void ClampPaddlePosition()
    {
        
        Vector2 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, lowerBoundY, upperBoundY);
        transform.position = pos;
    }
}
