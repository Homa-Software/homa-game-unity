using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rigidBody;

    private PlayerActionControls playerActionControls;

    float movementHorizontalInput;
    float movementVerticalInput;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    void Update()
    {
        movementHorizontalInput = playerActionControls.Movement.MoveLeftRight.ReadValue<float>();
        movementVerticalInput = playerActionControls.Movement.MoveUpDown.ReadValue<float>();
    }

    void FixedUpdate()
    {
        float fixedDeltaTime = Time.fixedDeltaTime;
        var horizontalMovement = movementHorizontalInput * moveSpeed * fixedDeltaTime;
        var verticalMovement = movementVerticalInput * moveSpeed * fixedDeltaTime;
        Vector2 movement = transform.position;
        movement.x += horizontalMovement;
        movement.y += verticalMovement;
        transform.position = movement;
    }
}
