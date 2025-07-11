using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongLogic : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed;
    private Vector2 direction;
    private Vector2[] randomDirection = { new Vector2(-1, -1), new Vector2(-1, 1), new Vector2(1, -1), new Vector2(1, 1) };

    void Start() { RandomStart(); }

    void RandomStart()
    {
        // Randomize the start direction
        int randomIndex = UnityEngine.Random.Range(0, randomDirection.Length);
        direction = randomDirection[randomIndex];
        rb.AddForce(direction * 3.0f, ForceMode2D.Impulse);
    }

    void Update()
    {
        direction = rb.velocity; // Track velocity, it holds magnitude and direction (for collision math)
        speed = direction.magnitude;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
            speed += 0.5f; // Increase speed on paddle hit

        Vector3 bounceDirection = Vector3.Reflect(direction.normalized, collision.contacts[0].normal); // Reflect params must be normalized so we get new direction
        rb.velocity = bounceDirection * speed; 
    }
}

