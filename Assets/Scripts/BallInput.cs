using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInput : MonoBehaviour
{
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;

    public float yBoundary = 3.4f;
    public float xBoundary = 5.0f;

    public float speed = 3.0f;

    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;

        // Button Atas Bawah
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }
        else
        {
            velocity.y = 0.0f;
        }

        // Button Kiri Kanan
        if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
        else
        {
            velocity.x = 0.0f;
        }

        rigidBody2D.velocity = velocity;

        // Batas
        Vector3 position = transform.position;

        // Batas Atas dan Bawah
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }
        transform.position = position;

        // Batas Kiri dan Kanan
        if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }
        transform.position = position;
    }
}
