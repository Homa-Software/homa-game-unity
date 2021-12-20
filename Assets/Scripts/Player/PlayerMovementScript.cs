using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rigidBody;
    public Animator animator;


    private PlayerActionControls playerActionControls;

    private Vector2 movement;
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

    private void Start()
    {
        movement = transform.position;
    }

    void Update()
    {
        movementHorizontalInput = playerActionControls.Movement.MoveLeftRight.ReadValue<float>();
        movementVerticalInput = playerActionControls.Movement.MoveUpDown.ReadValue<float>();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        float fixedDeltaTime = Time.fixedDeltaTime;
        float horizontalMovement = movementHorizontalInput * moveSpeed * fixedDeltaTime;
        float verticalMovement = movementVerticalInput * moveSpeed * fixedDeltaTime;

        movement.x += horizontalMovement;
        movement.y += verticalMovement;
        rigidBody.MovePosition(movement);
    }
}
