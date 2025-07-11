using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongLogic : MonoBehaviour
{

    // Drag and drop Rigidbody in Inspector
    public Rigidbody2D rb;
    [SerializeField]
    private float speed;
    private Vector2 direction;
    private Vector2[] rand =
    {
        new Vector2(-1, -1),
        new Vector2(-1, 1),
        new Vector2(1, -1),
        new Vector2(1, 1)
    };

    void Start() { RandomStart(); }

    void RandomStart()
    {
        // Randomize the start direction
        int randomIndex = UnityEngine.Random.Range(0, rand.Length);
        direction = rand[randomIndex];
        rb.AddForce(direction * 3.0f, ForceMode2D.Impulse);
    }

    void Update()
    {
        // Track velocity, it holds magnitude and direction (for collision math)
        direction = rb.velocity;
        speed = direction.magnitude;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
            speed += 0.5f; // Increase speed on paddle hit

        // Reflect params must be normalized so we get new direction
        Vector3 directions = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);
        rb.velocity = directions * speed;

        
    }
}

