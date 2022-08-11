using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput playerInput;
    private Animator animator;

    private Camera followCam;

    public float moveSpeed = 6f;
    public float jumpVelocity = 20f;

    //���߿� �ִ� ���� �÷��̾ ���� �ӵ��� ���ۼ�Ʈ�� �ӵ��� ���� �ִ���
    [Range(0.01f, 1f)] public float airCountrolPercent;

    public float currentSpeed => new Vector2(rb.velocity.x, rb.velocity.y).magnitude;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        followCam = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
    }

    public void Move(Vector2 moveInput)
    {
        transform.position = moveInput * moveSpeed;
    }
    
    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpVelocity,ForceMode2D.Force);
    }

    public void UpdateAnimation(Vector2 moveInput)
    {

    }
}
