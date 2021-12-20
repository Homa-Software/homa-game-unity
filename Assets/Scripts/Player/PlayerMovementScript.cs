using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rigidBody;
    public Animator animator;


    private PlayerActionControls playerActionControls;

    private Vector3 position;
    private Vector3 moveDir;
    float movementHorizontalInput;
    float movementVerticalInput;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        rigidBody = GetComponent<Rigidbody2D>();
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
        UpdatePlayerPositionValue();
    }

    void Update()
    {
        HandlePlayerMovementAnimation();
        HandlePlayerInput();
        NormalizePlayerMovementInput();

    }

    void FixedUpdate()
    {
        HandlePlayerMovement();
    }

    private void NormalizePlayerMovementInput()
    {
        moveDir = new Vector3(movementHorizontalInput, movementVerticalInput).normalized;
    }

    private void HandlePlayerMovement()
    {
        UpdatePlayerPositionValue();
        var fixedDeltaTime = Time.fixedDeltaTime;
        rigidBody.MovePosition(position + moveDir * moveSpeed * fixedDeltaTime);
    }

    private void HandlePlayerInput()
    {
        movementHorizontalInput = playerActionControls.Movement.MoveLeftRight.ReadValue<float>();
        movementVerticalInput = playerActionControls.Movement.MoveUpDown.ReadValue<float>();
    }

    private void UpdatePlayerPositionValue()
    {
        position = transform.position;
    }

    private void HandlePlayerMovementAnimation()
    {
        animator.SetFloat("Horizontal", moveDir.x);
        animator.SetFloat("Vertical", moveDir.y);
        animator.SetFloat("Speed", moveDir.sqrMagnitude);
    }
}
