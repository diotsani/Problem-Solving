using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    public float gerakX = 50.0f;
    public float gerakY = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        PushBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PushBall()
    {
        rigidBody2D.AddForce(new Vector2(gerakX, gerakY));
    }
}
