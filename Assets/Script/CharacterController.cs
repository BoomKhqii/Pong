using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    // Player Movement
    private Vector3 playerVelocity;
    private Vector2 movementInput = Vector2.zero;
    public float playerSpeed = 4.5f;

    public Rigidbody2D rb;

    public void OnMove(InputAction.CallbackContext context) { movementInput = context.ReadValue<Vector2>(); }

    
    void Update()
    {
        Debug.Log("Movement Input: " + movementInput);
        if (movementInput != Vector2.zero)
        {

            rb.velocity = new Vector2(movementInput.x, movementInput.y) * playerSpeed;

            Vector3 force = new Vector3(movementInput.x, 0, movementInput.y) * playerSpeed;
            //rb.AddForce(force);
        }
    }
    
}
