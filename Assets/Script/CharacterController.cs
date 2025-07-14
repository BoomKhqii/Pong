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

    void OnMove(InputAction.CallbackContext context) { movementInput = context.ReadValue<Vector2>(); }

    /*
    void Update()
    {
        if (movementInput != Vector2.zero)
        {
            // Determine the angle of the movement input
            float angle = Mathf.Atan2(movementInput.x, movementInput.y) * Mathf.Rad2Deg;

            rb.AddForce(angle * Time.deltaTime * playerSpeed, ForceMode2D.Force);
            transform.forward = moveDir;
        }

        playerVelocity.y += Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    */
}
