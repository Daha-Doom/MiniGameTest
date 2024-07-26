using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    float moveSpeed, rotationSpeed = 0.15f;

    Animator animator;

    Vector2 moveDirection;

    [SerializeField]
    bool canMove = true;

    private bool isMoving;
    public bool IsMoving
    {
        get => isMoving;
        set
        {
            if (isMoving != value)
            {
                isMoving = value;
                animator.SetBool(AnimatorString.IsMoving, value);
            }
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (canMove)
            MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 movement = new Vector3(moveDirection.x, 0f, moveDirection.y);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed);
            IsMoving = true;
        }
        else
            IsMoving = false;

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            canMove = false;
            animator.SetTrigger(AnimatorString.Victory);
        }
    }
}
