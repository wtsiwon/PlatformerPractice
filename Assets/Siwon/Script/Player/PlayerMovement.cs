using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput playerInput;

    public float moveSpeed = 6f;

    public float jumpPower = 20f;

    public bool isGround;

    public int jumpCount = 1;
    public bool isJump;
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move(playerInput.moveInput);
        Jump();
    }

    /// <summary>
    /// 움직여
    /// </summary>
    /// <param name="moveInput">무슨키가 눌렸나</param>
    public void Move(Vector2 moveInput)
    {
        rb.velocity = new Vector2(moveInput.x * moveSpeed,rb.velocity.y);
    }

    /// <summary>
    /// 점프
    /// </summary>
    public void Jump()
    {
        const float DISTANCE = 1f;


        Debug.DrawRay(rb.position, new Vector3(0, -DISTANCE, 0), new Color(1, 0, 0));

        RaycastHit2D ray = Physics2D.Raycast(rb.position, Vector2.down, DISTANCE, LayerMask.GetMask("Ground"));

        if (playerInput.jump && ray.collider != null && isJump == false)
        {
            rb.velocity = new Vector2(rb.velocity.x,0);
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isJump = true;
        }
    }
}
