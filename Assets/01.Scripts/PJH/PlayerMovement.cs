using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid;
    [SerializeField] private GroundCheck groundChecker;

    [SerializeField] private float moveSpeed, jumpPower;

    private Vector2 dir;


    private void FixedUpdate()
    {

        if (groundChecker.IsGround())
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Jump();
            }
        }
        
        
        rigid.linearVelocityX = moveSpeed * dir.x;
    }


    private void Jump()
    {
        rigid.AddForceY(jumpPower, ForceMode2D.Impulse);
    }

    private void OnMove(InputValue value)
    {
        dir =  value.Get<Vector2>();
    }
}
