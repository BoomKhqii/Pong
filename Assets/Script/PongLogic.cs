using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongLogic : MonoBehaviour
{
    private float ballSpeed = 2000f;
    private Rigidbody2D rb;
    private Vector2[] direction = new Vector2(-1, 1);
    /*
        TopLeft: -1, 1
        TopRight: 1, 1
        BottomLeft: -1, -1
        BottomRight: 1, -1
     */

    void Start() { rb = GetComponent<Rigidbody2D>(); }
    void Update()
    {
        rb.velocity = direction * ballSpeed * Time.deltaTime;
    }
}
