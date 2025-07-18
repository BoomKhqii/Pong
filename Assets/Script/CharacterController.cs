using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    // Player Movement
    private Vector2 movementInput = Vector2.zero;
    public float playerSpeed = 4.5f;


    public Rigidbody2D rb;

    public void OnMove(InputAction.CallbackContext context) { movementInput = context.ReadValue<Vector2>(); }

    
    void FixedUpdate()
    {
        rb.velocity = movementInput * playerSpeed;
    }
    
}
